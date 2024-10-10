using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public abstract class Person
    {
        #region Private Properties
        private string name { get; set; }
        private int age { get; set; }
        #endregion

        #region Public Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length > 0)
                {
                    this.name = value;
                }
            }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        #endregion

        #region Constructors
        public Person()
        {
            this.age = 0;
            this.name = "";
        }
        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        #endregion

        #region Public Methods
        public int GetAge() { return this.age; }

        /// <summary>
        /// Get the name of the person
        /// </summary>
        /// <returns></returns>
        public string GetName() { return this.name; }

        /// <summary>
        /// Display the values of the person
        /// </summary>
        public virtual void DisplayValue()
        {
            Console.WriteLine($"Name: {this.name}, Age: {this.age}");
        }

        /// <summary>
        /// Returns the values of the person
        /// </summary>
        public abstract string ReturnsValues();
        /*public virtual string ReturnsValues()
        {
            return $"Name: {this.name}, Age: {this.age}";
        }*/

        #endregion

        #region Destructor  

        /// <summary>
        /// Destructor
        /// </summary>
        ~Person()
        {
            Console.WriteLine("Destructor called");
        }

        #endregion

    }
}
