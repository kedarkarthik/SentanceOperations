using System;
using StringExercises.Abstract;
using StringExercises.Contract;

namespace StringExercises.Implementation.RearrangeCharactersDomain
{
    class ReverseCharactersUsingArraysInaSentance : SentanceValidator, IReverseSentance
    {
        public string Reverse(string sentance)
        {
            if (string.IsNullOrEmpty(sentance))
            {
                return "";
            }
            var reverseSentance = new char[sentance.Length];
            for (var i = 0; i < sentance.Length; i++)
            {
                reverseSentance[i] = sentance[sentance.Length - 1 - i];
            }

            return String.Concat(reverseSentance);

        }

        public override bool ValidateSentance(string sentance)
        {
            // this is a default implementation. At the least this needs to check is sentance is null or empty
            return String.IsNullOrEmpty(sentance);
        }
    }
}