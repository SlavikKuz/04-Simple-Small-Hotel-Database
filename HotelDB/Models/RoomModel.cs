﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDB.Model
{
    public class RoomModel
    {
        public long Id { get; set; }
        public string RoomDescription { get; set; }
        public int NumberBeds { get; set; }
        public string Floor { get; set; }
        public string Info  { get; set; }
        
        //ready or not to accept guests, not - renowation, flood, etc
        public string Active { get; set; }

    }
}
