using System;
using StringExercises.Enums;
using StringExercises.Factory;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            const string sentance = "I am kedar karthik.";

            var factory = new StringManipulationFactory();
            
            var options = Enum.GetValues(typeof (SentanceOperationTypes));

            foreach (var option in options)
            {
                Console.WriteLine("Result for: {0}", Enum.GetName(typeof (SentanceOperationTypes), option));
                Console.WriteLine(factory.GetReverseSentance((SentanceOperationTypes)option).Reverse(sentance) + Environment.NewLine + Environment.NewLine);                  
            }

            Console.ReadLine();
        }
    }
}

