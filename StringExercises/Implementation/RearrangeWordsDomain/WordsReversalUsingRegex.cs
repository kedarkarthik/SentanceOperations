using System;
using System.Text.RegularExpressions;
using StringExercises.Abstract;
using StringExercises.Contract;

namespace StringExercises.Implementation.RearrangeWordsDomain
{
    class WordsReversalUsingRegex : WordsReversalTemplate, IReverseSentance
    {
        // this is the adaptor method
        public string Reverse(string sentance)
        {
            return ReverseWordsInASentance(sentance);
        }

        public override string ReverseWordsImpl(string sentance)
        {
            string[] substrings = Regex.Split(sentance, "( )");    // Split on space
            Array.Reverse(substrings);
            return String.Concat(substrings);    
        }
    }
}