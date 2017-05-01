using System;
using System.Linq;
using StringExercises.Abstract;
using StringExercises.Contract;

namespace StringExercises.Implementation.RearrangeCharactersDomain
{
    class ReverseCharactersUsingInPLaceInaSentance : SentanceValidator, IReverseSentance
    {
        public string Reverse(string sentance)
        {
            var arr = sentance.ToArray();
            var startIndex = 0;
            var endIndex = sentance.Length - 1;
            while (startIndex < endIndex)
            {
                char temp = arr[startIndex];
                arr[startIndex] = arr[endIndex];
                arr[endIndex] = temp;

                startIndex++;
                endIndex--;
            }
            return string.Concat(arr);
        }

        public override bool ValidateSentance(string sentance)
        {
            // this is a default implementation. At the least this needs to check is sentance is null or empty
            return String.IsNullOrEmpty(sentance);
        }
    }
}