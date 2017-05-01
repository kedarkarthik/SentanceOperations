using System;
using System.Text.RegularExpressions;
using StringExercises.Abstract;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StringExercises.Contract;

namespace StringExercises.Implementation.RearrangeWordsDomain
{
    public class WordsReversalUsingStack : WordsReversalTemplate, IReverseSentance
    {

        public override string ReverseWordsImpl(string sentance)
        {
            var stack = new Stack<string>();
            var words = sentance.Split();
            foreach (var word in words)
            {
                stack.Push(word);
            }
            var stringBuilder = new StringBuilder();   
            while (stack.Count > 0)
            {
                string word = stack.Pop();
                switch (stack.Count)
                {
                    case 0:
                        stringBuilder.Append(word);
                        break;
                    default:
                        stringBuilder.Append(word + " ");
                        break;
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