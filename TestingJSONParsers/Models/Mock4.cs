using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestingSuite.Models
{
    public class Mock4
    {
        // List<Mock3> myDeserializedClass = JsonConvert.DeserializeObject<List<Mock3>(myJsonResponse);
        public class BillingAddress
        {
            private string street;
            private string city;
            private string country;

            [JsonConstructor]
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

            [JsonConstructor]
            public ShippingAddress(string street, string city, string country)
            {
                this.street = street;
                this.city = city;
                this.country = country;
            }
        }

        public class Address
        {
            private BillingAddress billingAddress;
            private ShippingAddress ShippingAddress;

            [JsonConstructor]
            public Address(BillingAddress billingAddress, ShippingAddress shippingAddress)
            {
                this.billingAddress = billingAddress;
                this.ShippingAddress = shippingAddress;
            }
        }

        public class Hobby
        {
            private string hobbyName;
            private double hoursWeek;

            [JsonConstructor]
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
            private List<Hobby> hobbies;

            [JsonConstructor]
            public Child(string firstName, string lastName, int age, bool attendsBoardingSchool, List<Hobby> hobbies)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.attendsBoardingSchool = attendsBoardingSchool;
                this.hobbies = hobbies;
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
            private LiscensePlate liscensePlate;

            [JsonConstructor]
            public VinNumber(string vin, LiscensePlate liscensePlate)
            {
                this.vin = vin;
                this.liscensePlate = liscensePlate;
            }
        }

        public class VehicleModel
        {
            private string model;
            private VinNumber vinNumber;

            [JsonConstructor]
            public VehicleModel(string model, VinNumber vinNumber)
            {
                this.model = model;
                this.vinNumber = vinNumber;
            }
        }

        public class VehicleType
        {
            private string type;
            private VehicleModel vehicleModel;

            [JsonConstructor]
            public VehicleType(string type, VehicleModel vehicleModel)
            {
                this.type = type;
                this.vehicleModel = vehicleModel;
            }
        }

        public class Vehicle
        {
            private string manufacturer;
            private VehicleType vehicleType;

            [JsonConstructor]
            public Vehicle(string manufacturer, VehicleType vehicleType)
            {
                this.manufacturer = manufacturer;
                this.vehicleType = vehicleType;
            }
        }

        public class Person
        {
            private string firstName;
            private string lastName;
            private int age;
            private bool married;
            private Address address;
            private List<Child> children;
            private List<Hobby> hobbies;
            private List<Vehicle> vehicles;

            [JsonConstructor]
            public Person(string firstName, string lastName, int age, bool married, Address address,
                List<Child> children, List<Hobby> hobbies, List<Vehicle> vehicles)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.married = married;
                this.address = address;
                this.children = children;
                this.hobbies = hobbies;
                this.vehicles = vehicles;
            }
        }

        public class Root
        {
            private Person person;

            [JsonConstructor]
            public Root(Person person)
            {
                this.person = person;
            }
        }
    }
}
