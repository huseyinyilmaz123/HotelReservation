using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class FormRooms : Form
    {
        public FormRooms()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.labelTime.Text = dateTime.ToString();
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMainPage fmp = new FormMainPage();
            fmp.Show();
        }

        private void btnRoom401_Click(object sender, EventArgs e)
        {
            //seçilen buton ile alakalı işlemlerin yapılmasını sağlar
            Button curButton = sender as Button;
            int selectedRoomNo = Convert.ToInt32(curButton.Tag.ToString());



            RoomManager roomManager = new RoomManager(new EfRoomDal());
            Room room1 = new Room();
            room1 = roomManager.Get(selectedRoomNo);
            lblRoomNo.Text = room1.RoomNo.ToString();
            lblPrice.Text = room1.Price.ToString();
            lblFloorNo.Text = room1.Floor.ToString();
            lblAvailability.Text = room1.Fullness == 0 ? "Available" : "NotAvailable";

        }
    }
}
