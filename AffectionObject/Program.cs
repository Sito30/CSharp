using System;

namespace AffectionObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile obj = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
            obj.SetHobbies(new string[] {"listening to audiobooks and podcasts", "\nplaying rec sports like bowling and kickball", "\nwriting a speculative fiction novel", "\nreading advice columns"});
            Console.WriteLine(obj.ViewProfile());
        }
    }
}