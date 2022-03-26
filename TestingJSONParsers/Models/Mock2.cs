using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSuite.Models
{
    public class Mock2
    {
        // List<Mock2> myDeserializedClass = JsonConvert.DeserializeObject<List<Mock2>(myJsonResponse);
        public class BillingAddress
        {
            private string street;
            private string city;
            private string country;

            public BillingAddress(string street, string city, string country)
            {
                this.street = street;
                this.city = city;
                this.country = country;
            }
        }

        public class ShippingAddress
        {
            private string street;
            private string city;
            private string country;

            public ShippingAddress(string street, string city, string country)
            {
                this.street = street;
                this.city = city;
                this.country = country;
            }
        }

        public class Address
        {
            public BillingAddress BillingAddress { get; set; }
            public ShippingAddress ShippingAddress { get; set; }

            public Address(BillingAddress billingAddress, ShippingAddress shippingAddress)
            {
                BillingAddress = billingAddress;
                ShippingAddress = shippingAddress;
            }
        }

        public class Hobby
        {
            private string hobbyName;
            private double hoursWeek;
            
            public Hobby(string hobbyName, double hoursWeek)
            {
                this.hobbyName = hobbyName;
                this.hoursWeek = hoursWeek;
            }
        }

        public class Child
        {
            private string firstName;
            private string lastName;
            private int age;
            private bool attendsBoardingSchool;
            public List<Hobby> Hobbies { get; set; }

            public Child(string firstName, string lastName, int age, bool attendsBoardingSchool, List<Hobby> hobbies)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.attendsBoardingSchool = attendsBoardingSchool;
                Hobbies = hobbies;
            }
        }

        public class LiscensePlate
        {
            private string plate;
           
            public LiscensePlate(string plate)
            {
                this.plate = plate;
            }
        }

        public class VinNumber
        {
            private string vin;
            public LiscensePlate LiscensePlate { get; set; }

            public VinNumber(string vin, LiscensePlate liscensePlate)
            {
                this.vin = vin;
                LiscensePlate = liscensePlate;
            }
        }

        public class VehicleModel
        {
            private string model;
            public VinNumber VinNumber { get; set; }

            public VehicleModel(string model, VinNumber vinNumber)
            {
                this.model = model;
                VinNumber = vinNumber;
            }
        }

        public class VehicleType
        {
            private string type;
            public VehicleModel VehicleModel { get; set; }

            public VehicleType(string type, VehicleModel vehicleModel)
            {
                this.type = type;
                VehicleModel = vehicleModel;
            }
        }

        public class Vehicle
        {
            private string manufacturer;
            public VehicleType VehicleType { get; set; }

            public Vehicle(string manufacturer, VehicleType vehicleType)
            {
                this.manufacturer = manufacturer;
                VehicleType = vehicleType;
            }
        }

        public class Person
        {
            private string firstName;
            private string lastName;
            private int age;
            private bool married;
            public Address Address { get; set; }
            public List<Child> Children { get; set; }
            public List<Hobby> Hobbies { get; set; }
            public List<Vehicle> Vehicles { get; set; }
            public Person(string firstName, string lastName, int age, bool married, Address address,
                List<Child> children, List<Hobby> hobbies, List<Vehicle> vehicles)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.married = married;
                Address = address;
                Children = children;
                Hobbies = hobbies;
                Vehicles = vehicles;
            }
        }

        public class Root
        {
            public Person Person { get; set; }
            public Root(Person person)
            {
                Person = person;
            }
        }
    }
}
