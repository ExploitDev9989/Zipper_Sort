namespace Zipper_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("Emter another word: ");
            string word2 = Console.ReadLine();
            string final = "";
            string longWord = "";
            string shortWord = "";
            if (word2.Length > word1.Length)
            {
                longWord = word2;
                shortWord = word1;
            }
            else
            {
                longWord = word1;
                shortWord = word2;
            }
            for (int i = 0; i < longWord.Length; i++)
            {
                if (i < word1.Length)
                {
                    final += word1[i];
                    
                }
                if (i < word2.Length) 
                {
                    final += word2[i];
                }
                
            }
            Console.WriteLine(final);








        }
    }
}
