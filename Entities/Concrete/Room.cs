using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Room:IEntity
    {
        public int RoomId { get; set; }
        public int Floor { get; set; }
        public decimal Price { get; set; }
        public int RoomNo { get; set; }
        public int Fullness { get; set; }
    }
}
