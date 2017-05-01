using System;
using System.Text.RegularExpressions;
using StringExercises.Abstract;
using StringExercises.Contract;

namespace StringExercises.Implementation.RearrangeWordsDomain
{
    class WordsReversalUsingInPlace : WordsReversalTemplate, IReverseSentance
    {
        // this is the adaptor method
        public string Reverse(string sentance)
        {
            return ReverseWordsInASentance(sentance);
        }

        public override string ReverseWordsImpl(string sentance)
        {
            //default split param is space
            var words = sentance.Split();
            var startIndex = 0;
            var endIndex = words.Length - 1;
            while (startIndex < endIndex)
            {
                var temp = words[startIndex];
                words[startIndex] = words[endIndex];
                words[endIndex] = temp;

                startIndex++;
                endIndex--;
            }

            return String.Join(" ", words);
        }
    }
}