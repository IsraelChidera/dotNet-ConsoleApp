namespace PigLatin
{
    public class Translate
    {        
        public string word;
        public Translate(string name)
        {
            word=name;
        }

        public void printPigLatin()
        {
            // Getting a text from user
            Console.BackgroundColor = ConsoleColor.Green;            
            Console.ResetColor();
            //string text = Console.ReadLine();

            if (!(word == ""))
            {
                // splitting and looping through each word
                string[] subs = word.Split(' ');

                foreach (var word in subs)
                {
                    // removing the last char from each word
                    string remo = word.Remove(0, 1);
                    string subst = word.Substring(0, 1);

                    //  adding the removed word to end inserting
                    // "ay" string 
                    string wrd = word.Remove(0, 1) + word.Substring(0, 1);
                    string finalwrd = wrd.Insert(wrd.Length, "ay");
                    Console.WriteLine("Translated word: " + finalwrd);                    
                }
            }
        }   
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a word you'd love to translate");
            string str = Console.ReadLine();
            Translate car = new Translate(str);
            car.printPigLatin();            
        }
    }
}