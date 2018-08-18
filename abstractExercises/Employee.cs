using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractExercises
{
    class Employee : Person
    {
        //public int Id { get; set; }

        public override void SayName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine($"Name: {fullName}");
            Console.ReadLine();
        }






    }


}
