using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            ////string fullName = "R Jay Kline";
            ////string favoriteCar = "Tesla Model 3";
            ////string favoriteSuperHero = "Iron Man";
            ////Console.WriteLine(fullName);
            ////Console.WriteLine(favoriteCar);
            ////Console.WriteLine(favoriteSuperHero);

            ////Homework for Jan 16:
            ////double firstNumb;
            ////double secondNumb;

            //////Problem 1: Lisa is cooking muffins. The recipe calls for 7 cups of sugar. She has already put in 2 cups. How many more cups does she need to put in?
            ////firstNumb = 7;
            ////secondNumb = 2;
            ////Console.WriteLine(firstNumb - secondNumb);
            //////Problem 2: At a restaurant, Mike and his three friends decided to divide the bill evenly. If each person paid $13 then what was the total bill?
            ////firstNumb = 13;
            ////secondNumb = 4;
            ////Console.WriteLine(firstNumb * secondNumb);
            //////Problem 3:  How many packages of diapers can you buy with $40 if one package costs $8?
            ////firstNumb = 40;
            ////secondNumb = 8;
            ////Console.WriteLine(firstNumb / secondNumb);
            //////Problem 4:  Last Friday Trevon had $29. Over the weekend he received some money for cleaning the attic. He now has $41.  How much money did he receive?
            ////firstNumb = 41;
            ////secondNumb = 29;
            ////Console.WriteLine(firstNumb - secondNumb);
            //////Problem 5: Last week Julia ran 30 miles more than Pranav. Julia ran 47 miles. How many miles did Pranav run?
            ////firstNumb = 47;
            ////secondNumb = 30;
            ////Console.WriteLine(firstNumb - secondNumb);
            //////Problem 6: How many boxes of envelopes can you buy with $12 if one box costs $3?
            ////firstNumb = 12;
            ////secondNumb = 3;
            ////Console.WriteLine(firstNumb / secondNumb);
            //////Problem 7: After paying $5.12 for a salad, Norachai has $27.10. How much money did he have before buying the salad?
            ////firstNumb = 5.12;
            ////secondNumb = 27.10;
            ////Console.WriteLine(firstNumb + secondNumb);

            ////Homework for Jan 18:
            //double firstNumb;
            //double secondNumb;

            //Console.WriteLine("Enter your name, please.");
            //string name = Console.ReadLine();

            ////Problem 1: Lisa is cooking muffins. The recipe calls for 7 cups of sugar. She has already put in 2 cups. How many more cups does she need to put in?
            //firstNumb = 7;
            //secondNumb = 2;
            //double sumProb1 = firstNumb - secondNumb;
            //Console.WriteLine("{0} will need {1} cups of sugar", name, sumProb1);

            ////Problem 2: At a restaurant, Mike and his three friends decided to divide the bill evenly. If each person paid $13 then what was the total bill?
            //firstNumb = 13;
            //secondNumb = 4;
            //double sumProb2 = firstNumb * secondNumb;
            //string mikeFriends = "Mike, Fred, George, and Ringo";
            //Console.WriteLine("{0} each paid $13 for a grand total of: ${1}", mikeFriends, sumProb2);


            ////Problem 3:  How many packages of diapers can you buy with $40 if one package costs $8?
            //firstNumb = 40;
            //secondNumb = 8;
            //Console.WriteLine(firstNumb / secondNumb);
            ////Problem 4:  Last Friday Trevon had $29. Over the weekend he received some money for cleaning the attic. He now has $41.  How much money did he receive?
            //firstNumb = 41;
            //secondNumb = 29;
            //Console.WriteLine(firstNumb - secondNumb);
            ////Problem 5: Last week Julia ran 30 miles more than Pranav. Julia ran 47 miles. How many miles did Pranav run?
            //firstNumb = 47;
            //secondNumb = 30;
            //Console.WriteLine(firstNumb - secondNumb);
            ////Problem 6: How many boxes of envelopes can you buy with $12 if one box costs $3?
            //firstNumb = 12;
            //secondNumb = 3;
            //Console.WriteLine(firstNumb / secondNumb);
            ////Problem 7: After paying $5.12 for a salad, Norachai has $27.10. How much money did he have before buying the salad?
            //firstNumb = 5.12;
            //secondNumb = 27.10;
            //Console.WriteLine(firstNumb + secondNumb);

            //Homework Jan 25th
            
            int[] jlist = new int[25];

            for (int i = 0; i < jlist.Length; i++)
            {
                Console.WriteLine("Enter numbers") ;
                jlist[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < jlist.Length; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.Write(jlist[i] + ",");
                }









            }
        }
    }
}
