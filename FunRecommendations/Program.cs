using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace FunRecommendations
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> optionsActivitiesArray = new Dictionary<string, string>();
            optionsActivitiesArray.Add(new KeyValuePair<string, string>("Action", "Stock Car Racing"));
            optionsActivitiesArray.Add(new KeyValuePair<string, string>("Chilling", "Hiking"));
            optionsActivitiesArray.Add(new KeyValuePair<string, string>("Danger", "Skydiving"));
            optionsActivitiesArray.Add(new KeyValuePair<string, string>("Good Food", "To Taco Bell"));


            foreach (KeyValuePair<string, string> keyValuePairs in optionsActivitiesArray)
            {
                Console.WriteLine("What are you in the mood for? Here are some options");
                Thread.Sleep(500);
                foreach (string key in optionsActivitiesArray.Keys)
                {
                    Console.WriteLine(key);
                }

                Console.WriteLine();

                Console.WriteLine("Type your answer below:");
                string answer1 = Console.ReadLine();

                {
                    if (keyValuePairs.Key.Contains(answer1))
                    {
                        Console.WriteLine(answer1);
                    }

                    string[] vehicles = { "sneakers", "a sedan", "a VW bus", "a private jet" };

                    Console.WriteLine("How many peeps are you bringing with? Enter a number");
                    string input = Console.ReadLine();
                    int guestAmount = int.Parse(input);
                    foreach (var kvp in optionsActivitiesArray)
                    {
                        string answer2 = kvp.Value;

                        for (int i = 0; guestAmount <= 11; i++)
                        {
                            if (guestAmount == 0)
                            {
                                string travelRec = vehicles[0];
                                Console.WriteLine
                                    (
    string.Format("Ok if you're in the mood for {0}, you should go to {1}and travel in {2}", answer1, answer2, travelRec));
                                return;
                            }
                            else if (guestAmount <= 4)
                            {
                                string travelRec = vehicles[0];
                                Console.WriteLine
                                    (
    string.Format("Ok if you're in the mood for {0}, you should go to {1}and travel in {2}", answer1, answer2, travelRec));
                                return;
                            }
                            else if (guestAmount <= 10)
                            {
                                string travelRec = vehicles[0];
                                Console.WriteLine
                                    (
    string.Format("Ok if you're in the mood for {0}, you should go to {1}and travel in {2}", answer1, answer2, travelRec));
                                return;
                            }
                            else if (guestAmount >= 11)
                            {
                                string travelRec = vehicles[0];
                                Console.WriteLine
                                    (
    string.Format("Ok if you're in the mood for {0}, you should go to {1}and travel in {2}", answer1, answer2, travelRec));
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a number and press enter");
                            }
                        }
                    }
                }
            }
        }
    }
}