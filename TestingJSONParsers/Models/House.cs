using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSuite.Models
{
    public class House
    {
        public int Nr { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public Garage Garage { get; set; }

        public House(int nr, string street, string city, Garage garage)
        {
            Nr = nr;
            Street = street;
            City = city;
            Garage = garage;
        }
    }
}
