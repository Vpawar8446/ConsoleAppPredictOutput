using System;

namespace ConsoleAppPredictOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] str = new String[] {

                "Sunflower","Rose","Jasmine","Marigld","Lily","Lotus"
            };

            // copying an array

            String[] Info = str;

            foreach (string k in Info)

            {

                Console.WriteLine(k[2]);        // student output :- Jasmine

            }
        }
    }
}
