using System;

namespace Session04Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is a sentence of text, it contains many words.   ";

            string inputData = "  ";

            // kontrollera om strängen är tilldelad ett värde
            bool inputIsNukk = inputData == null;
            bool inputIsEmpty = inputData == string.Empty; // inputData == "";

            // snabbmetoder för att kontrollera innhållet i en sträng
            bool inputIsNullOrEmpty = string.IsNullOrEmpty(inputData);

            //Ytterligare kontroller om strängen innehåller vettig data
            bool inputIsNullOrWhitespace = string.IsNullOrWhiteSpace(inputData);

            string sentence = "    This is a sentence of text, it contains many words.   ";

            // Trimma bort mellanslag och andra whitespace-teckan från början och slutet.
            string trimmedSentence = sentence.Trim();
            string endTrimmesSebtence = sentence.TrimEnd();

            // det går att ange ett speciellt tecken som skall tas bort
            string punctuationTrimmesSentence = sentence.TrimEnd(',');

            string searchForWord = "text";
            int indexOfText = trimmedSentence.IndexOf(searchForWord);

            // hämta bara området som letas efter
            string subString = sentence.Substring(indexOfText, searchForWord.Length);
            string beforeHitSubstring = trimmedSentence.Substring(0, indexOfText);

            // stora små bokstäver
            string uppercaseString = trimmedSentence.ToUpper();
            string lowercaString = trimmedSentence.ToLower();

            //struntar i språkinställningar
            string uppercaseInveariantString = trimmedSentence.ToUpperInvariant();

            char oneCharacter = trimmedSentence[0];

            for (int i = 0; i < trimmedSentence.Length; i++)
            {
                // Loopa igenom en strängm tecken för tecken.
                char currentCharacter = trimmedSentence[i];

            }

            char[] trimmedSentenceCharArray = trimmedSentence.ToCharArray();

            // modifierat datat;

            trimmedSentence = new string(trimmedSentenceCharArray);

            trimmedSentence = trimmedSentence + "...";// samma sak som ovan
            // trimmedSentence += "...";

            //1
            //123
            //2
            //23
            //3

            //001
            //002
            //003
            //023
            //123

            var numberInstring = "12";
            var paddedNumberInString.PadLeft


        }
    }
}
