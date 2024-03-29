namespace Week6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terminal terminal = new Terminal();

            terminal.newCompany();
            terminal.newCompany();

            terminal.newBus(1);
            terminal.newBus(1);

            terminal.getPassengers();
            terminal.getBuses();




        }
    }
}
