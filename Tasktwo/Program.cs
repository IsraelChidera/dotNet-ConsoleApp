namespace Tasktwo
{
    public class LeapYearGen
    {
        public int lastleapyear;

        public LeapYearGen()
        {
            lastleapyear = 2020;
        }

        public void leapyears()
        {

              // last leap year
                int lastLeapYear = lastleapyear;

                // looping through for the next 20 years
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine($"Leap Year: {lastLeapYear = lastLeapYear + 4}");
                }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LeapYearGen leapYearGen = new LeapYearGen();
            leapYearGen.leapyears();
            Console.WriteLine("Hello, World!");
        }
    }
}