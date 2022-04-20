namespace RugbyPlayerList
{
    internal class Rugby
    {

        List<string> list = new List<string>() { "One","Two"};
        void AddToList()
        {
            list.Add("Three");
        }
        void PrintList()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
         public static List<string> AddRugbyPlayers()
        {
             List<string> RugbyPlayers = new List<string>();
            RugbyPlayers.Add("Martin Johnson");
            RugbyPlayers.Add("Jonah Lomu");
            RugbyPlayers.Add("David Campese");
            RugbyPlayers.Add("Brian O'Driscoll");
            RugbyPlayers.Add("Michael Jones");

            return RugbyPlayers;
        }
    }
}
