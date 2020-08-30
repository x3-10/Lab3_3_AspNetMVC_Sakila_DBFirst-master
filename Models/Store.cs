﻿using System;
using System.Collections.Generic;

namespace Lab3_3_AspNetMVC_Sakila_DBFirst.Models
{
    public partial class Store
    {
        public Store()
        {
            Customer = new HashSet<Customer>();
            Inventory = new HashSet<Inventory>();
            Staff = new HashSet<Staff>();
        }

        public int StoreId { get; set; }
        public byte ManagerStaffId { get; set; }
        public int AddressId { get; set; }
        public DateTime LastUpdate { get; set; }

        public Address Address { get; set; }
        public Staff ManagerStaff { get; set; }
        public ICollection<Customer> Customer { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<Staff> Staff { get; set; }
    }
}
