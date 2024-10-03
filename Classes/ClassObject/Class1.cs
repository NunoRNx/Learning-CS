using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Pessoa
    {
        public int age {  get; set; }
        public string name {  get; set; }
        public string address { get; set; }
        public int phone { get; set; }

        #region Construtor
        public Pessoa(int age, string name, string address, int phone)
        {
            if (age < 18)
            {
                Console.WriteLine("Must be 18 or older to sign up!");
            }
            else
            {
                this.age = age;
                this.name = name;
                this.address = address;
                this.phone = phone;
            }
        }
        #endregion
        #region injection

        public int Age
        { 
            get{ return this.age; }
            set
            {
                if (value >= 18)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("Must be 18 or older to sign up!");
                }
            }
        }
        public int Phone
        { 
            get{ return this.phone; }
            set
            {
                if (value != 0)
                {
                    this.phone = value;
                }
            }
        }
        public string Name
        { 
            get{ return this.name; }
            set{ this.name = value; }
        }
        public string Address
        { 
            get{ return this.address; }
            set{ this.address = value; }
        }
        #endregion
        public void DataDisplay()
        {
            Console.WriteLine($"\nName: {this.name}\nAge: {this.age}\nPhone: {this.phone}\nAddress: {this.address}");
        }

    }
}
