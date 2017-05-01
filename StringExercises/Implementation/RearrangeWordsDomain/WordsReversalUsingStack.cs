using System;
using System.Text.RegularExpressions;
using StringExercises.Abstract;
using System.Collections;
using System.Collections.Concurrent;
using System.Text;
using System.Threading.Tasks;
using StringExercises.Contract;

namespace StringExercises.Implementation.RearrangeWordsDomain
{
    public class WordsReversalUsingStack : WordsReversalTemplate, IReverseSentance
    {

        public override string ReverseWordsImpl(string sentance)
        {
            var stack = new ConcurrentStack<string>();
            var words = sentance.Split();
            Parallel.ForEach(words, (word) => stack.Push(word));
            var stringBuilder = new StringBuilder();   
            while (!stack.IsEmpty)
            {
                string word;
                if (stack.TryPop(out word))
                {
                    stringBuilder.Append(word + " ");                    
                }
            }
            return stringBuilder.ToString();
        }


        /// <summary>
        /// this method is also used as an adapter becuase the actual implementation comes fromt he abstract class but the method names are different
        /// </summary>
        /// <param name="sentance"></param>
        /// <returns></returns>
        public string Reverse(string sentance)
        {
            return ReverseWordsInASentance(sentance);
        }
    }
}