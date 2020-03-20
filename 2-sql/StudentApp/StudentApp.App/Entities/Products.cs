using System;
using System.Collections.Generic;

namespace StudentApp.App.Entities
{
    public partial class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double? Price { get; set; }
    }
}
