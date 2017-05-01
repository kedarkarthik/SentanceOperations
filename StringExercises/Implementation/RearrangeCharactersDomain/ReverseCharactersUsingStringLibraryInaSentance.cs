using System;
using System.Linq;
using StringExercises.Abstract;
using StringExercises.Contract;

namespace StringExercises.Implementation.RearrangeCharactersDomain
{
    class ReverseCharactersUsingStringLibraryInaSentance : SentanceValidator, IReverseSentance
    {
        public string Reverse(string sentance)
        {
            return string.IsNullOrEmpty(sentance) ? "" : String.Concat(sentance.Reverse());
        }

        public override bool ValidateSentance(string sentance)
        {
            // this is a default implementation. At the least this needs to check is sentance is null or empty
            return String.IsNullOrEmpty(sentance);
        }
    }
}