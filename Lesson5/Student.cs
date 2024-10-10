using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Student : Person
    {
        #region Private properties
        public string studentId { get; set; }
        public string course { get; set; }
        #endregion
    
        #region Public properties
        public string StudentId
        {
            get { return this.studentId; }
            set { this.studentId = value; }
        }
        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        #endregion
    
        #region Constructors
        public Student()
        {
            StudentId = "";
            Course = "";
        }
    
        public Student(string name, int age, string studentId, string course)
            : base(name, age) // Correctly call the base constructor
        {
            StudentId = studentId;
            Course = course;
        }
    
        /// <summary>
        /// Construtor without calling base constructor
        /// </summary>
        //public Student(string name, int age, string studentId, string course)
        //{
        //    Name = name;
        //    Age = age;
        //    StudentId = studentId;
        //    Course = course;
        //}
    
        #endregion
    
        #region Public Methods
        /// <summary>
        /// Display the values of the student and from the person
        /// </summary>
        public override void DisplayValue()
        {
            base.DisplayValue();
            Console.WriteLine($"Student ID: {StudentId}, Course: {Course}");
        }
    
        /// <summary>
        /// Returns the values of the student and the person
        /// </summary>
        /// <returns></returns>
        public override string ReturnsValues()
        {
            return $"{base.ReturnsValues()} Student ID: {StudentId}, Course: {Course}";
        }
        #endregion
    
        #region Destructor  
    
        /// <summary>
        /// Destructor
        /// </summary>
        ~Student()
        {
            Console.WriteLine("Destructor called");
        }
    
        #endregion
    }
}
