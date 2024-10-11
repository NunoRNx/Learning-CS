namespace ClassFunctions
{
    public class Person
    {
        public string? name { get; set; }
        public Book book { get; set; }
        public Person(string? name, Book BorrowedBook)
        {
            this.name = name;
            this.book =  BorrowedBook;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public class Student : Person
        {
            public int studentId { get; set; }
            public Student(string? FullName, int id, Book BorrowedBook)
            : base(FullName, BorrowedBook)
            {
                this.studentId = id;
            }
        }
        public class Prof : Person
        {
            public int profId { get; set; }
            public Prof(string? name, int id, Book BorrowedBook)
            : base(name, BorrowedBook)
            {
                this.profId = id;
            }
        }
        public class Func : Person
        {
            public int funcId { get; set; }
            public Func(string? name, int id, Book BorrowedBook)
            : base(name, BorrowedBook)
            {
                this.funcId = id;
            }
        }
        ~Person() { }
    }
}
