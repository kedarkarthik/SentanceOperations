using StringExercises.Contract;
using StringExercises.Enums;
using StringExercises.Implementation.RearrangeCharactersDomain;
using StringExercises.Implementation.RearrangeWordsDomain;

namespace StringExercises.Factory
{
    public class StringManipulationFactory
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
                case SentanceOperationTypes.WordsReversalUsingRegex:
                    handler = new WordsReversalUsingRegex();
                    break;
                case SentanceOperationTypes.WordsReversalUsingStack:
                    handler = new WordsReversalUsingStack();
                    break;
                case SentanceOperationTypes.WordsReversalUsingInPlace:                    
                    handler = new WordsReversalUsingInPlace();
                    break;
                default:
                    handler = new ReverseCharactersUsingStringLibraryInaSentance();
                    break;
            }

            return handler;
        }

    }
}