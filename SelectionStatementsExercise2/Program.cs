namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you favorite subjects?");
            string uInput = Console.ReadLine();

            //subjects Math, English, History, Physical Education, Government

            switch (uInput.ToLower())
            {
                case "Math":
                    Console.WriteLine("Ah yeah, math. I hated it but I'm much more interestsed now. Go figure?");
                    break;

                case "English":
                    Console.WriteLine("Always did poorley here. Just take a look at my punctuation and spelling.");
                    break;

                case "History":
                    Console.WriteLine("History is good. It's too bad its not the full truth though. Have you ever heard of, Hard Core History?");
                    break;

                case "Physical Education":
                    Console.WriteLine("Easy A, even though I skipped it most of the time.");
                    break;

                case "Government":
                    Console.WriteLine("Man, Don't even get me started here");
                    break;
                default:
                    Console.WriteLine("I've never heard of that. ");
                    break;
            }
        }
    }
}