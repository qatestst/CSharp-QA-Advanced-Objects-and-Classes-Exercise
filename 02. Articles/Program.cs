namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // логика на въвеждане и принтиране

            string articleData = Console.ReadLine();
            //articleData = "Fight club, love story, Martin Scorsese"
            string title = articleData.Split(", ")[0];
            string content = articleData.Split(", ")[1];
            string author = articleData.Split(", ")[2];

            Article article = new Article(title, content, author);

            int countCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < countCommands; i++) 
            {
                string command = Console.ReadLine();
                string[] commandParts = command.Split(": ");
                string commandName = commandParts[0];
                string commandParameter = commandParts[1];

                switch(commandName)
                    case "Edit": 

                    break;
                case "ChangeAuthor":
                    
                    break;
                case "Rename":

                    break;
            
            
            }
        }
    }
}