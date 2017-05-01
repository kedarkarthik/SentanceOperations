using System;
using System.ComponentModel.Design;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExercises;
using StringExercises.Contract;
using StringExercises.Enums;
using StringExercises.Factory;

namespace StringExercisesTest
{
    [TestClass]
    public class WordsReversalTests
    {
        StringManipulationFactory _factory = new StringManipulationFactory();

        public WordsReversalTests()
        {
            
        }

        [TestMethod]
        public void Test_For_Empty_String()
        {
            CallAllOperationsAtOnce("");
        }

        [TestMethod]
        public void Test_For_Null_String()
        {
            CallAllOperationsAtOnce(null);
        }

        private void CallAllOperationsAtOnce(string sentenace)
        {
            Assert.AreEqual(_factory.GetReverseSentance(SentanceOperationTypes.WordsReversalUsingRegex).Reverse(sentenace), "");
            Assert.AreEqual(_factory.GetReverseSentance(SentanceOperationTypes.WordsReversalUsingStack).Reverse(sentenace), "");
            Assert.AreEqual(_factory.GetReverseSentance(SentanceOperationTypes.WordsReversalUsingInPlace).Reverse(sentenace), "");
        }

        [TestMethod]
        public void Test_For_Words_All_Strategies_Return_The_Same_Result()
        {
            var sentence = "I am going to take a walk.";

            var regexSentence = _factory.GetReverseSentance(SentanceOperationTypes.WordsReversalUsingRegex).Reverse(sentence);
            var stackSentence = _factory.GetReverseSentance(SentanceOperationTypes.WordsReversalUsingRegex).Reverse(sentence);
            var inPlaceSentence = _factory.GetReverseSentance(SentanceOperationTypes.WordsReversalUsingRegex).Reverse(sentence);


            Assert.IsTrue(regexSentence == stackSentence);
            Assert.IsTrue(stackSentence == inPlaceSentence);
            Assert.IsTrue(inPlaceSentence == regexSentence);
        }

        [TestMethod]
        public void Test_For_Words_Count()
        {
            var sentence = "I am going to take a walk.";

            var reverseSentence = _factory.GetReverseSentance(SentanceOperationTypes.ReverseUsingArrays).Reverse(sentence);

            Assert.IsTrue(sentence.Split().Count() == reverseSentence.Split().Count());
        }

        //reflexive and symmetrical 
        [TestMethod]
        public void Test_For_Words_Reverse_And_Reversal_Of_Reversal_Contents()
        {
            var sentence = "I am going to take a walk.";
            var reverseSentence = _factory.GetReverseSentance(SentanceOperationTypes.WordsReversalUsingRegex).Reverse(sentence);
            var reverseSentenceOfReversal = _factory.GetReverseSentance(SentanceOperationTypes.WordsReversalUsingRegex).Reverse(reverseSentence);
            
            Assert.IsTrue(sentence == reverseSentenceOfReversal);
        }

        [TestMethod]
        public void Test_For_Words_Reverse_Invalid_Sentence()
        {
            var sentence = "I am going to take a walk";
            var reverseSentence = _factory.GetReverseSentance(SentanceOperationTypes.WordsReversalUsingRegex).Reverse(sentence);
            Assert.IsTrue(reverseSentence == "");
        }

        //[TestMethod]
        //public void Test_For_Reverse_Contents_Case_Fail()
        //{
        //    var sentence = "I am going to take a walk.";
        //    var reverseSentence = _factory.GetReverseSentance(SentanceOperationTypes.ReverseUsingArrays).Reverse(sentence);
        //    sentence = "I Am going to take a walk.";
        //    int endEndex = sentence.Length - 1;
        //    bool failed = false;
        //    for (var startIndex = 0; startIndex < sentence.Length; startIndex++)
        //    {
        //        if (sentence[startIndex] != reverseSentence[reverseSentence.Length - 1 - startIndex])
        //        {
        //            failed = true;
        //        }
        //    }
        //    Assert.IsTrue(failed);
        //}

    }
}
