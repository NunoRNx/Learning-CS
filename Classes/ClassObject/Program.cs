namespace ClassObject
{
    internal class Program
    {
        static void Main()
        {
            int age, phone;
            string? name, add, input;
            Pessoa pessoa=null;
            Console.Write("Name: ");
            name=Console.ReadLine();
            
            while (true)
            {
                Console.Write("Phone: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out phone) && input.Length<=10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Make sure the phone number has less then 10 digits.");
                }
            }
            Console.Write("Address: ");
            add = Console.ReadLine();
            while (true)
            {
                Console.Write("Age: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out age) && input.Length<=3)
                {
                    try
                    {
                        pessoa = new Pessoa(age, name, add, phone);
                        break;
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid age.");
                }
            }
            if (pessoa.name != null)
            {
                pessoa.DataDisplay();
            }
        }
    }
}
