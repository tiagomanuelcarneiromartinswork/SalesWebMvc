﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvcUdemyFinalProject.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(string name)
        {
            Name = name;
        }

        public void AddSeller(Seller s)
        {
            Sellers.Add(s);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(s => s.TotalSales(initial, final));
        }


    }
}
