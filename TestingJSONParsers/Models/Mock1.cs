using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSuite.Models
{
    public class Mock1
    {
        public class BillingAddress
        {
            public string Street { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
        }

        public class ShippingAddress
        {
            public string Street { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
        }

        public class Address
        {
            public BillingAddress BillingAddress { get; set; }
            public ShippingAddress ShippingAddress { get; set; }
        }

        public class Hobby
        {
            public string HobbyName { get; set; }
            public double HoursWeek { get; set; }
        }

        public class Child
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public bool AttendsBoardingSchool { get; set; }
            public List<Hobby> Hobbies { get; set; }
        }

        public class LiscensePlate
        {
            public string Plate { get; set; }
        }

        public class VinNumber
        {
            public string VIN { get; set; }
            public LiscensePlate LiscensePlate { get; set; }
        }

        public class VehicleModel
        {
            public string Model { get; set; }
            public VinNumber VinNumber { get; set; }
        }

        public class VehicleType
        {
            public string Type { get; set; }
            public VehicleModel VehicleModel { get; set; }
        }

        public class Vehicle
        {
            public string Manufacturer { get; set; }
            public VehicleType VehicleType { get; set; }
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public bool Married { get; set; }
            public Address Address { get; set; }
            public List<Child> Children { get; set; }
            public List<Hobby> Hobbies { get; set; }
            public List<Vehicle> Vehicles { get; set; }
        }

        public class Root
        {
            public Person Person { get; set; }
        }
    }
}
