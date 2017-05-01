using StringExercises.Contract;
using StringExercises.Enums;
using StringExercises.Implementation.RearrangeCharactersDomain;
using StringExercises.Implementation.RearrangeWordsDomain;

namespace StringExercises.Factory
{
    class StringManipulationFactory
    {
        public IReverseSentance GetReverseSentance(SentanceOperationTypes type)
        {
            IReverseSentance handler = null;
            switch (type)
            {
                case SentanceOperationTypes.None:
                    handler = new ReverseCharactersUsingStringLibraryInaSentance();
                    break;
                case SentanceOperationTypes.ReverseUsingStringLibrary:
                    handler = new ReverseCharactersUsingStringLibraryInaSentance();
                    break;
                case SentanceOperationTypes.ReverseUsingArrays:
                    handler = new ReverseCharactersUsingArraysInaSentance();
                    break;
                case SentanceOperationTypes.ReversecharactersInPlace:
                    handler = new ReverseCharactersUsingStringLibraryInaSentance();
                    break;
                case SentanceOperationTypes.ReverseWordsUsingRegex:
                    handler = new WordsReversalUsingRegex();
                    break;
                case SentanceOperationTypes.ReverseWordsUsingConcurrentStack:
                    handler = new WordsReversalUsingStack();
                    break;
                default:
                    handler = new ReverseCharactersUsingStringLibraryInaSentance();
                    break;
            }

            return handler;
        }

    }
}