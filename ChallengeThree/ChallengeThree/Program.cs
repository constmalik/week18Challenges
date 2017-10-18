using System;
using System.Collections.Generic;

namespace ChallengeThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> roadtohire = new Dictionary<string, int>();

            roadtohire.Add("Malik", 21);
            roadtohire.Add("Victoria", 23);
            roadtohire.Add("Miguel", 21);
            roadtohire.Add("Chris", 21);
            roadtohire.Add("Juan", 19);
            roadtohire.Add("Markus", 18);
            roadtohire.Add("Lesly MVP", 18);
            roadtohire.Add("Angel", 19);
            roadtohire.Add("Mickey", 19);
            roadtohire.Add("Ivan", 18);
            roadtohire.Add("Teia", 23);
            roadtohire.Add("Brittany", 23);
            roadtohire.Add("Ian", 20);
            roadtohire.Add("Hunter", 19);
            roadtohire.Add("Mark", 25);
            //count the keys in dictionary 
            int count1 = roadtohire.Count;

            Console.WriteLine(count1);

            roadtohire.Remove("Mark");

            int count2 = roadtohire.Count;

            Console.WriteLine(count2);

            if(roadtohire.ContainsKey("Malik")) 
            {
                int me = roadtohire["Malik"];
                Console.WriteLine("Malik is " + me);
            }


        }
    }
}
