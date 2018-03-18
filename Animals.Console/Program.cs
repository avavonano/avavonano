//using System;
//using System.Threading;
//using Animals.Engine;
//using Animals.Engine.Animals.Implementations;

//namespace Animals
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int totalDeaths = 10;
//            int catDeaths = 0;
//            int dogDeaths = 0;
//            int commonDeaths = 0;
//            for (int i = 0; i < totalDeaths; ++i)
//            {
//                Cat cat = new Cat("cat", false, false, 200, 19, 10);
//                Dog dog = new Dog("dog", true, 650, 80, 18);
//                cat.LoggingOff = true;
//                dog.LoggingOff = true;
//                int firstPlayerFlag = Utilities.RandomNumberBetween(0, 2);
//                bool catDied = false;
//                bool dogDied = false;
//                for (int roundIdx = firstPlayerFlag; roundIdx < 1000; ++roundIdx)
//                {
//                    if (roundIdx % 2 == 0)
//                    {
//                        cat.Talk();
//                        cat.Attack(dog);
//                    }
//                    else
//                    {
//                        dog.Talk();
//                        dog.Attack(cat);
//                    }
//                    catDied = cat.CheckDeath();
//                    dogDied = dog.CheckDeath();
//                    if (catDied || dogDied)
//                    {
//                        if (catDied && dogDied)
//                        {
//                            commonDeaths += 1;
//                        }
//                        catDeaths += catDied ? 1 : 0;
//                        dogDeaths += dogDied ? 1 : 0;

//                        break;
//                    }

//                }

//            }
//            Console.WriteLine("Cat died " + catDeaths + " (" + Math.Round((catDeaths * 100.0) / (totalDeaths + commonDeaths), 2) + "%)");
//            Console.WriteLine("Dog died " + dogDeaths + " (" + Math.Round((dogDeaths * 100.0) / (totalDeaths + commonDeaths), 2) + "%)");
//            Console.WriteLine("Common died " + commonDeaths + " (" + Math.Round((commonDeaths * 100.0) / (totalDeaths + commonDeaths), 2) + "%)");
//            Console.ReadLine();
//        }
//    }




//}
