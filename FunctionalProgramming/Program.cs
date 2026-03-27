namespace FunctionalProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };
            numbers.ForEach(num =>
            {
                int result = Exercises001.AddTen(num);
                Console.WriteLine(result);
            });

            List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };
            words.ForEach(word =>
            {
                bool result = Exercises001.GrammarCheck(word);
                Console.WriteLine(result);

            });
        }
    }
}
