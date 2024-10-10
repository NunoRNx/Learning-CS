namespace DLL
{
    
    public class Pessoas
    {
        private string name { get; set; }
        private string address { get; set; }
        private int age { get; set; }
    
        public Pessoas(string name, string address, int age)
        {
            this.name = name;
            this.address = address;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine($"Nome: {this.name}\nEnd: {this.address}\nIdade: {this.age}");
        }
        public class Aluno : Pessoas
        {
            private int studentID { get; set; }
            private string course { get; set; }
            private int courseYear { get; set; }
            private double gradesAverege { get; set; }
    
            public Aluno(string name, string address, int age, int id, string course, int courseYear, double averege) : base(name, address, age)
            {
                this.studentID = id;
                this.course = course;
                this.courseYear = courseYear;
                this.gradesAverege = averege;
            }
            public void Display()
            {
                base.Display();
                Console.WriteLine($"ID: {this.studentID}\nCourse: {this.course}\nYear: {this.courseYear}\nAverege: {this.gradesAverege}");
            }
        }
        public class Prof : Pessoas
        {
            private int profID { get; set; }
            private string tCourse { get; set; }
            private string chair { get; set; }
            public Prof(string name, string address, int age, int id, string course, string chair) : base(name, address, age)
            {
                this.profID = id;
                this.tCourse = course;
                this.chair = chair;
            }
            public void Display()
            {
                base.Display();
                Console.WriteLine($"ID: {this.profID}\nCourse: {this.tCourse}\nChair: {this.chair}");
            }
        }
        public class Funcionario : Pessoas
        {
            private int workerID { get; set; }
            private string department { get; set; }
            private string role { get; set; }
    
            public Funcionario(string name, string address, int age, int id, string department, string role) : base(name, address, age)
            {
                this.workerID = id;
                this.department = department;
                this.role = role;
            }
            public void Display()
            {
                base.Display();
                Console.WriteLine($"ID funcionario: {this.workerID}\nDepartamento: {this.department}\nCargo: {this.role}");
            }
        }
    }
}
