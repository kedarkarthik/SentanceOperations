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
    public class CharactersReverseTests
    {
        StringManipulationFactory _factory = new StringManipulationFactory();

        public CharactersReverseTests()
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
            Assert.AreEqual(_factory.GetReverseSentance(SentanceOperationTypes.ReverseUsingArrays).Reverse(sentenace), "");
            Assert.AreEqual(_factory.GetReverseSentance(SentanceOperationTypes.ReverseUsingStringLibrary).Reverse(sentenace), "");
            Assert.AreEqual(_factory.GetReverseSentance(SentanceOperationTypes.ReversecharactersInPlace).Reverse(sentenace), "");
        }

        [TestMethod]
        public void Test_For_Character_Count()
        {
            var sentence = "I am going to take a walk.";

            Assert.AreEqual(_factory.GetReverseSentance(SentanceOperationTypes.ReverseUsingArrays).Reverse(sentence).Length, sentence.Length);
        }

        [TestMethod]
        public void Test_For_Reverse_Contents()
        {
            var sentence = "I am going to take a walk.";
            var reverseSentence = _factory.GetReverseSentance(SentanceOperationTypes.ReverseUsingArrays).Reverse(sentence);
            int endEndex = sentence.Length - 1;
            bool failed = false;
            for (var startIndex = 0; startIndex < sentence.Length; startIndex++)
            {
                if (sentence[startIndex] != reverseSentence[reverseSentence.Length - 1 - startIndex])
                {
                    failed = true;
                }
            }
            Assert.IsFalse(failed);
        }

        [TestMethod]
        public void Test_For_Reverse_Contents_Fail()
        {
            var sentence = "I am going to take a walk.";
            var reverseSentence = _factory.GetReverseSentance(SentanceOperationTypes.ReverseUsingArrays).Reverse(sentence);
            sentence = "M am going to take a walk.";
            int endEndex = sentence.Length - 1;
            bool failed = false;
            for (var startIndex = 0; startIndex < sentence.Length; startIndex++)
            {
                if (sentence[startIndex] != reverseSentence[reverseSentence.Length - 1 - startIndex])
                {
                    failed = true;
                }
            }
            Assert.IsTrue(failed);
        }

        [TestMethod]
        public void Test_For_Reverse_Contents_Case_Fail()
        {
            var sentence = "I am going to take a walk.";
            var reverseSentence = _factory.GetReverseSentance(SentanceOperationTypes.ReverseUsingArrays).Reverse(sentence);
            sentence = "I Am going to take a walk.";
            int endEndex = sentence.Length - 1;
            bool failed = false;
            for (var startIndex = 0; startIndex < sentence.Length; startIndex++)
            {
                if (sentence[startIndex] != reverseSentence[reverseSentence.Length - 1 - startIndex])
                {
                    failed = true;
                }
            }
            Assert.IsTrue(failed);
        }

    }
}
