namespace ExDLL
{
    public class Book
    {
        private int id { get; set; }
        private string? name { get; set; }
        private string? lang { get; set; }
        private string? author { get; set; }
        private string? catg { get; set; }
        #region constructor
        public Book(string? name, int id, string? lang, string? author, string? catg)
        {
            this.name=name;
            this.id=id;
            this.lang = lang;
            this.author=author;
            this.catg=catg;
        }
        #endregion
        #region injector
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Lang
        {
            get { return this.lang; }
            set 
            {
                if(value.ToLower() == "english" || value.ToLower() == "portugues")
                {
                    this.lang = value;
                }
                else
                {
                    throw new Exception("Idioma não reconhecido");
                }
            }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public string Catg
        {
            get { return this.Catg; }
            set { this.Catg = value; }
        }
        #endregion
        public class Person
        {
            public string? name { get; set; }
            public Book book { get; set; }
            public Person(string? name, int bookID, string? bookName, string? lang, string? author, string? catg)
            {
                this.name = name;
                this.book = new Book(bookName, bookID, lang, author, catg);
            }
            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }
            public class Student : Person
            {
                public int studentId { get; set; }
                public Student(string? FullName, int id, int bookID, string? bookName, string? lang, string? author, string? catg)
                : base(FullName, bookID, bookName, lang, author, catg)
                {
                    this.studentId = id;
                }
            }
            public class Prof : Person
            {
                public int profId { get; set; }
                public Prof(string? FullName, int id, int bookID, string? bookName, string? lang, string? author, string? catg)
                : base(FullName, bookID, bookName, lang, author, catg)
                {
                    this.profId = id;
                }
            }
            public class Func : Person
            {
                public int funcId { get; set; }
                public Func(string? FullName, int id, int bookID, string? bookName, string? lang, string? author, string? catg)
                : base(FullName, bookID, bookName, lang, author, catg)
                {
                    this.funcId = id;
                }
            }
            ~Person() { }
        }
    }
}
