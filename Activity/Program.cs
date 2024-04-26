namespace Activity
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NewPlayer player1 = new NewPlayer("oktay","avşar",2002,"Left");
            player1.setFootballClub("Fenerbahçe");
            player1.setPosition("Forward");

            player1.show();

        }
    }
}
