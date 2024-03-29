namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.newContact();
            phoneBook.newContact();
            phoneBook.newContact();
            Console.Clear();

            phoneBook.addNumber(1,123456);

            phoneBook.getContacts();

            Console.WriteLine("**********************************");

            phoneBook.getContact(1);
            Console.WriteLine("**********************************");

            phoneBook.getContact(9);
            Console.WriteLine("**********************************");

            phoneBook.getContacts("Ankara");
            Console.WriteLine("**********************************");

            phoneBook.getContacts("Bursa");
            Console.WriteLine("**********************************");

            phoneBook.deleteContact(3);
            phoneBook.getContacts();
            Console.WriteLine("**********************************");







        }
    }
}
