﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccess.Concrete.EntityFramework;

namespace Form1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                MessageBox.Show("Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUsername.Focus();
                return;
            }
            try
            {
                using (HotelContext hotelContext=new HotelContext())
                {
                    //using linq to query data
                    var query = from o in hotelContext.USERS
                                where o.UserName == textBoxUsername.Text && o.Password == textBoxPassword.Text
                                select o;
                    //check if user exists
                    if (query.SingleOrDefault() != null)
                    {
                        MessageBox.Show("You have been successfully logged in.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Add your code process login here
                        this.Hide();
                        FormMainPage fmp = new FormMainPage();
                        fmp.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your username or password is incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            
        }

    }
}
