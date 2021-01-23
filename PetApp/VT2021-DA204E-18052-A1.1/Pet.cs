using System;
using System.Collections.Generic;
using System.Text;

namespace VT2021_DA204E_18052_A1._1
{
    class Pet
    {
        private string name;
        private int age;
        private bool isFemale;

        /// <summary>
        /// Gets data from console user.
        /// </summary>
        public void GetInput()
        {
            Console.Write("Welcome to the Pet register. \n Please write the name of your pet: ");
            this.name = Console.ReadLine();

            Console.Write("Please enter the age of your pet: ");
            this.age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please, enter the sex of your pet: Male or Female?");
            string sex = Console.ReadLine();
            if (sex.Equals("Male"))
            {
                this.isFemale = false;
            } else
            {
                this.isFemale = true;
            }
            Console.Write("Thanks for the information!\n\n");
        }

        /// <summary>
        /// Prints in console the data save in this class.
        /// </summary>
        public void ToConsole()
        {
            Console.Write(String.Format("=== PET ===\n Name: {0}\n Age: {1}\n Sex: {2}", this.name, this.age, this.isFemale ? "Female" : "Male"));
        }
    }
}
