using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSuite.Models
{
    public class Garage
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Garage(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
