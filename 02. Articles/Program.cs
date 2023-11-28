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
                //1. command = "Edit: {new content}. Split(": ") -> ["Edit" , "{new content}"]
                //2. command = "ChangeAuthor: {new author}".Split(": ") -> ["ChangeAuthor", "{new author}"]
                //3. command = "Rename: {new title}".Split(": ") -> ["Rename", "{new title}"] 
                string[] commandParts = command.Split(": ");
                string commandName = commandParts[0]; // "Edit", "ChangeAuthor", "Rename"
                string commandParameter = commandParts[1];

                switch (commandName)
                {
                    case "Edit":
                        // променяме съдържанието
                        article.Edit(commandParameter);
                        break;
                    case "ChangeAuthor":
                        //променяме автора
                        article.ChangeAuthor(commandParameter);
                        break;
                    case "Rename":
                        // променяме заглавието
                        article.Rename(commandParameter);
                        break;
                }
            
            }
            //принтираме статия
            //{Заглавие} - {съдържание}: {автор}
            //1-ви начин
            // Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");

            //2-ри начин за отпечатване
            Console.WriteLine(article.ToString());


        }
    }
}