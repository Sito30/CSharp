using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AffectionObject
{
    public class Profile
    {
        //Fields
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        //Constructors
        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[0];
        }
        
        //Methods
        public string ViewProfile()
        {
            if (this.hobbies.Length > 0)
            {
                string userHobbies = "";
                foreach (string hobby in this.hobbies)
                {
                    userHobbies += hobby;
                }

                string userProfile = $"Name: {name},\nAge: {age},\nCity: {city},\nCountry: {country}.\nPronouns: {pronouns},\nHobbies: {userHobbies}";
                return userProfile;
            }
            else
            {
                string userProfile = $"Name: {name},\nAge: {age},\nCity: {city},\nCountry: {country},\nPronouns: {pronouns}";
                return userProfile;
            }
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

        //Properties
        private string Name
        { get; set; }

        private int Age
        { 
            get { return age; }
            set 
            {
                if (value < 18)
                {
                    Console.WriteLine("You must be at least 18 years of age to access this platform");
                }
                else
                {
                    age = value;
                }
            }
        }

        private string City
        { get; set; }

        private string Country
        { get; set; }

        private string Pronouns
        { 
            get { return pronouns; }
            set { name = value; } 
        }
    }
}