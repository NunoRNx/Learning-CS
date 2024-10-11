namespace ClassFunctions
{
    public class Book
    {
        private static int autoID = 1;
        private int id { get; set; }
        private string? name { get; set; }
        private string? lang { get; set; }
        private string? author { get; set; }
        private string? catg { get; set; }
        private bool borrowed { get; set; }
        #region constructor
        public Book()
        {
            this.id=autoID++;
            this.borrowed=false;
        }
        #endregion
        #region injector
        public int Id
        {
            get { return this.id; }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.name=value;
                }
                else
                {
                    throw new Exception("Input Invalid");
                }
            }
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
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.author = value;
                }
                else
                {
                    throw new Exception("Input Invalid");
                }
            }
        }
        public string Catg
        {
            get { return this.catg; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.catg = value;
                }
                else
                {
                    throw new Exception("Input Invalid");
                }
            }
        }
        public bool IsBorrowed
        {
            get { return this.borrowed; }
            set { this.borrowed = value; }
        }
        #endregion
    }
}
