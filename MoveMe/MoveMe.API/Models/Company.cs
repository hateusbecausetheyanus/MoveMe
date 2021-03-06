﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Spatial;

namespace MoveMe.API.Models
{
    public class Company
    {
        public Company()
        {
            Orders = new Collection<Order>();
        }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Telephone { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Employees { get; set; }
        public int Radius { get; set; }
        public decimal HourlyRate { get; set; }
        public DbGeography Location { get; set; }
        

        
        //Navigation

        public virtual ICollection<Order> Orders { get; set; }
        public virtual User User { get; set; }


    }
}