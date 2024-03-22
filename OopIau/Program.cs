namespace OopIau
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*Console.Write("Enter your name: ");
            string name= Console.ReadLine();
            Console.WriteLine("Hello "+name);
            Console.Write("Your age?");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are "+age+" year old");*/

            Univrsity univrsity = new Univrsity();
            univrsity.newAuthor();
            univrsity.newAuthor();

            univrsity.newBook(1);
            univrsity.newBook(1);
            univrsity.newBook(2);

            univrsity.getAuthor();
            univrsity.getBook(1);
            univrsity.getAuthor();


        }
    }
}
