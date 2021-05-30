using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Room:IEntity
    {
        public int RoomId { get; set; }
        public int RoomFlag { get; set; }
        public int Floor { get; set; }
        public int Price { get; set; }
        public int RoomNo { get; set; }
        public int Fullness { get; set; }
    }
}
