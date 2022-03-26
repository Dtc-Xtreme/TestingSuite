using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSuite.Models
{
    public class Mock3
    {
        // List<Mock3> myDeserializedClass = JsonConvert.DeserializeObject<List<Mock3>(myJsonResponse);
        public class BillingAddress
        {
            private string streetValue;
            private string cityValue;
            private string countryValue;

            public string Street
            {
                get
                {
                    return streetValue;
                }
                set
                {
                    //if (value != string.Empty)
                        streetValue = value;
                }
            }
            
            public string City
            {
                get
                {
                    return cityValue;
                }
                set
                {
                    //if (value != string.Empty)
                        cityValue = value;
                }
            }
            
            public string Country
            {
                get
                {
                    return countryValue;
                }
                set
                {
                    //if (value != string.Empty)
                        countryValue = value;
                }
            }

            public BillingAddress(string street, string city, string country)
            {
                Street = street;
                City = city;
                Country = country;
            }
        }

        public class ShippingAddress
        {
            private string streetValue;
            private string cityValue;
            private string countryValue;

            public string Street
            {
                get
                {
                    return streetValue;
                }
                set
                {
                    //if (value != string.Empty)
                        streetValue = value;
                }
            }
           
            public string City
            {
                get
                {
                    return cityValue;
                }
                set
                {
                    //if (value != string.Empty)
                        cityValue = value;
                }
            }
            
            public string Country
            {
                get
                {
                    return countryValue;
                }
                set
                {
                    //if (value != string.Empty)
                        countryValue = value;
                }
            }

            public ShippingAddress(string street, string city, string country)
            {
                Street = street;
                City = city;
                Country = country;
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
            private string hobbyNameValue;
            private double hoursWeekValue;

            public string HobbyName
            {
                get
                {
                    return hobbyNameValue;
                }
                set
                {
                    //if (value != string.Empty)
                        hobbyNameValue = value;
                }
            }
            
            public double HoursWeek
            {
                get
                {
                    return hoursWeekValue;
                }
                set
                {
                    //if (value != 0)
                        hoursWeekValue = value;
                }
            }

            public Hobby(string hobbyName, double hoursWeek)
            {
                HobbyName = hobbyName;
                HoursWeek = hoursWeek;
            }
        }

        public class Child
        {
            private string firstNameValue;
            private string lastNameValue;
            private int ageValue;
            private bool attendsBoardingSchoolValue;

            public string FirstName
            {
                get
                {
                    return firstNameValue;
                }
                set
                {
                    //if (value != string.Empty)
                        firstNameValue = value;
                }
            }
            
            public string LastName
            {
                get
                {
                    return lastNameValue;
                }
                set
                {
                    //if (value != string.Empty)
                        lastNameValue = value;
                }
            }
            
            public int Age
            {
                get
                {
                    return ageValue;
                }
                set
                {
                    //if (value != 0)
                        ageValue = value;
                }
            }
            
            public bool AttendsBoardingSchool
            {
                get
                {
                    return attendsBoardingSchoolValue;
                }
                set
                {
                    attendsBoardingSchoolValue = value;
                }
            }

            public List<Hobby> Hobbies { get; set; }

            public Child(string firstName, string lastName, int age, bool attendsBoardingSchool, List<Hobby> hobbies)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                AttendsBoardingSchool = attendsBoardingSchool;
                Hobbies = hobbies;
            }
        }

        public class LiscensePlate
        {
            private string plateValue;

            public string Plate
            {
                get
                {
                    return plateValue;
                }
                set
                {
                    //if (value != string.Empty)
                        plateValue = value;
                }
            }

            public LiscensePlate(string plate)
            {
                Plate = plate;
            }
        }

        public class VinNumber
        {
            private string vinValue;

            public string VIN
            {
                get
                {
                    return vinValue;
                }
                set
                {
                    //if (value != string.Empty)
                        vinValue = value;
                }
            }

            public LiscensePlate LiscensePlate { get; set; }

            public VinNumber(string vin, LiscensePlate liscensePlate)
            {
                VIN = vin;
                LiscensePlate = liscensePlate;
            }
        }

        public class VehicleModel
        {
            private string modelValue;

            public string Model
            {
                get
                {
                    return modelValue;
                }
                set
                {
                    //if (value != string.Empty)
                        modelValue = value;
                }
            }

            public VinNumber VinNumber { get; set; }

            public VehicleModel(string model, VinNumber vinNumber)
            {
                Model = model;
                VinNumber = vinNumber;
            }
        }

        public class VehicleType
        {
            private string typeValue;

            public string Type
            {
                get
                {
                    return typeValue;
                }
                set
                {
                    //if (value != string.Empty)
                        typeValue = value;
                }
            }

            public VehicleModel VehicleModel { get; set; }

            public VehicleType(string type, VehicleModel vehicleModel)
            {
                Type = type;
                VehicleModel = vehicleModel;
            }
        }

        public class Vehicle
        {
            private string manufacturerValue;

            public string Manufacturer
            {
                get
                {
                    return manufacturerValue;
                }
                set
                {
                    //if (value != string.Empty)
                        manufacturerValue = value;
                }
            }

            public VehicleType VehicleType { get; set; }

            public Vehicle(string manufacturer, VehicleType vehicleType)
            {
                Manufacturer = manufacturer;
                VehicleType = vehicleType;
            }
        }

        public class Person
        {
            private string firstNameValue;
            private string lastNameValue;
            private int ageValue;
            private bool marriedValue;

            public string FirstName
            {
                get
                {
                    return firstNameValue;
                }
                set
                {
                    //if (value != string.Empty)
                        firstNameValue = value;
                }
            }

            public string LastName
            {
                get
                {
                    return lastNameValue;
                }
                set
                {
                    //if (value != string.Empty)
                        lastNameValue = value;
                }
            }

            public int Age
            {
                get
                {
                    return ageValue;
                }
                set
                {
                    //if (value != 0)
                        ageValue = value;
                }
            }
            
            public bool Married
            {
                get
                {
                    return marriedValue;
                }
                set
                {
                    marriedValue = value;
                }
            }

            public Address Address { get; set; }

            public List<Child> Children { get; set; }

            public List<Hobby> Hobbies { get; set; }

            public List<Vehicle> Vehicles { get; set; }

            public Person(string firstName, string lastName, int age, bool married, Address address,
                List<Child> children, List<Hobby> hobbies, List<Vehicle> vehicles)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Married = married;
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
