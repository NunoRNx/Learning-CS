using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassFunctions;

namespace Main
{
    class Program
    {
        static void Main()
        {
            int max = 100;
            Book[] book = new Book[max];
            Person[] person = new Person[max];
            int i = 0, j = 0;
            int r = 1;
            do
            {
                r = Function.Menu();
                switch (r)
                {
                    case 1:
                        if (i >= max)
                        {
                            Console.WriteLine("Limite de Livros alcançado");
                        }
                        else
                        {
                            book[i] = Function.AddBook();
                            i++;
                        }
                        break;
                    case 2:
                        if (j >= max)
                        {
                            Console.WriteLine("Todos os livros já foram empresatados");
                        }
                        else if (i > 0)
                        {
                            person[j] = Function.Borrow(book, max, out int x);
                            if (person[j] != null)
                            {
                                book[x].IsBorrowed = true;
                                j++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhum Livro registado");
                        }
                        break;
                    case 3:
                        if (Function.BookReturn(book, person, max, j))
                        {
                            j--;
                        }
                        break;
                    case 4:
                        if (i > 0)
                        {
                            Function.BookList(book, max);
                        }
                        else
                        {
                            Console.WriteLine("Nenhum Livro registado");
                        }
                        break;
                    default:
                        break;
                }
            } while (r != 5);
        }
    }
}
