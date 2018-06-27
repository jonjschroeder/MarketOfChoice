﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoCTestApp.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            Name = name;
            ID = id;

        }
    }
}