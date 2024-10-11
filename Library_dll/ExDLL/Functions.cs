namespace ClassFunctions
{
    public class Function
    {
        public static int Menu()
        {
            Console.WriteLine("\n1-Novo Livro");
            Console.WriteLine("2-Emprestimo de Livro");
            Console.WriteLine("3-Livro Returnado");
            Console.WriteLine("4-Lista de livros");
            Console.WriteLine("5-Sair");
            Console.Write("R: ");
            int r = 0;
            while(!Int32.TryParse(Console.ReadLine(), out r) || (r<1 || r>5))
            {
                Console.WriteLine("Input inválido.");
                Console.Write("R: ");
            }
            return r;
        }
        public static Book AddBook()
        {
            Book book = new Book();
            while (true)
            {
                Console.Write("Nome: ");
                try
                {
                    book.Name = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                Console.Write("Idioma (english / portugues): ");
                try
                {
                    book.Lang = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                Console.Write("Autor: ");
                try
                {
                    book.Author = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                Console.Write("Categoria: ");
                try
                {
                    book.Catg = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return book;
        }
        public static Person Borrow(Book[] book, int max, out int x)
        {
            int type = 0;
            do
            {
                Console.WriteLine("Professor, estudante ou funcionário?");
                string? cargo = Console.ReadLine();
                if (cargo != null)
                {
                    switch (cargo.ToLower())
                    {
                        case "professor":
                            type = 1;
                            break;
                        case "estudante":
                            type = 2;
                            break;
                        case "funcionario":
                        case "funcionário":
                            type = 3;
                            break;
                        default:
                            Console.WriteLine("Cargo não reconhecido");
                            break;
                    }
                }
            } while (type == 0);

            Console.Write("Nome: ");
            string? name = Console.ReadLine();
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            int j=0;
            do
            {
                BookList(book,max);
            }while (!Requisitar(book, max, out j));
            Person person = null;
            if (book[j].IsBorrowed)
            {
                type = 4;
            }
            switch (type)
            {
                case 1:
                    person = new Person.Prof(name, id, book[j]);
                    break;
                case 2:
                    person = new Person.Student(name, id, book[j]);
                    break;
                case 3:
                    person = new Person.Func(name, id, book[j]);
                    break;
                default:
                    Console.WriteLine("Livro já foi requisitado");
                    break;
            }
            x = j;
            return person;
        }
        public static void BookList(Book[] book, int max)
        {
            int i = 0;
            Console.WriteLine("\nLista de livros:");
            while (book[i]!=null) 
            {
                Console.WriteLine(book[i].Name);
                Console.WriteLine($"ID: {book[i].Id}\n");
                Console.WriteLine($"Author: {book[i].Author}");
                Console.WriteLine($"Categoria: {book[i].Catg}");
                Console.Write("Disponivél: ");
                if (!book[i].IsBorrowed)
                {
                    Console.WriteLine("Sim");
                }
                else
                {
                    Console.WriteLine("Não");
                }
                i++;
            }
        }
        public static bool Requisitar(Book[] book, int max, out int j)
        {
            j = 0;
            Console.WriteLine("Livro a requesitar");
            int i=BookSearch(book, max);
            if (i == -1)
            {
                return false;
            }
            j = i;
            return true;
        }
        public static bool BookReturn(Book[] book, Person[] person, int max, int lastPerson)
        {
            if(lastPerson == 0)
            {
                Console.WriteLine("Nenhum livro requisitado");
                return false;
            }
            int i = BookSearch(book, max);
            if (i == -1)
            {
                Console.WriteLine("Livro não encontrador");
                return false;
            }
            if (!book[i].IsBorrowed)
            {
                Console.WriteLine("Livro não está requisitado");
                return false;
            }
            int j = BorrowerSearch(book[i].Name, person, max);
            if (j == -1)
            {
                Console.WriteLine("ERROR: Nenhum usuário encontrado para este livro");
                return false;
            }
            person[j] = person[lastPerson - 1];
            person[lastPerson - 1].book = null;
            person[lastPerson - 1] = null;

            book[i].IsBorrowed = false;

            return true;
        }
        public static int BookSearch(Book[] book, int max)
        {
            Console.Write("Nome do livro: ");
            string? bookName = Console.ReadLine();
            int i = 0;
            while (i < max)
            {
                if (book[i].Name.ToLower() == bookName.ToLower())
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public static int BorrowerSearch(string bookName, Person[] person, int max)
        {
            int i = 0;
            while (i < max)
            {
                if (person[i].book.Name.ToLower() == bookName.ToLower())
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
    }
}
