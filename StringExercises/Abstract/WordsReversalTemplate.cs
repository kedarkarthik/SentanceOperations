namespace StringExercises.Abstract
{
    /// <summary>
    /// This class uses template pattern, where the base clas gives a template to be filled by sub classes
    /// </summary>
    public abstract class WordsReversalTemplate
    {
        
        //only one anstract method which determines the data sructure / algorithm used in revering the words
        public abstract string ReverseWordsImpl(string sentance);              

        //default implementation
        protected bool ValidateSentance(string sentance)
        {
            if (string.IsNullOrEmpty(sentance))
            {
                return false;
            }
            if (!sentance.Contains("."))
            {
                return false;
            }
            return true;      
        }

        //default implementation
        protected string ConvertFirstCharacterToUpperCase(string sentance)
        {
            var letters = sentance.ToCharArray();
            if (char.IsLower(letters[0]))
            {
                letters[0] = char.ToUpper(letters[0]);
            }

            return string.Join("", letters);
        }

        //default implementation
        protected string HandlePeriods(string sentance)
        {
            return string.IsNullOrEmpty(sentance)? "" : sentance + ".";
        }

        //default implementation
        protected string ReverseWordsInASentance(string sentance)
        {
            if (ValidateSentance(sentance))
            {
                // this is a very diluted implementation of a decorator pattern, where reversed sentance is decorated with additional grammar rules 
                return HandlePeriods(ConvertFirstCharacterToUpperCase((ReverseWordsImpl(sentance.ToLower().Replace(".", "")))));
            }
            else
            {
                return "";
            }
        }
    }
}