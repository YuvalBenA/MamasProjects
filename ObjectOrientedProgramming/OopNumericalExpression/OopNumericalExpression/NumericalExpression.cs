using System;
using System.Collections.Generic;
using System.Text;


namespace OopNumericalExpression
{
    class NumericalExpression
    {
        private long Number { get; set; }

        public NumericalExpression(long number)
        {
            Number = number;
        }

        public override string ToString()
        {

            long copyNumber = Number;
            if (Number < 1000000000000)
            {
                if (copyNumber == 0)
                {
                    return "zero";
                }
                return WriteNumber(copyNumber);
            }
            else
            {
                return "Number out of range. "; 
            }
        }

        public string WriteNumber(long number)
        {
            if (number == 0)
            {
                return "";
            }
            string[] numbersTillTwenty = { "zero ", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine ","ten ",
                "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen ","eighteen ", "ninteen "};
            string[] roundNumbersTillOneHundred = { "zero ", "ten ", "twenty ", "thirty ", "fourty ", "fifty ", "sixty ", "seventy ", "eighty ", "ninety " };
            string[] numbersSizeName = { "", "", "", "hundred ", "thousand ", "thousand ", "thousand ", "million ", "million ", "million ",
                "billion ", "billion ", "billion " };
            Dictionary<int, string> sizeName = new Dictionary<int, string>();
            for (int i = 0; i < 13; i++)
            {
                sizeName.Add(i, numbersSizeName[i]);
            }
            if (number > 20)
            {
                if (number >= 100)
                {
                    int numbersLength = (int)(Math.Log10(number)+1);
                    int myKey = KeyByValue(sizeName, numbersSizeName[numbersLength]);
                    long firstPart = Convert.ToInt64(number / Math.Pow(10, myKey));
                    string thisSizeName = sizeName[(int)(Math.Log10(number)+1)];
                    long secondPart = number - Convert.ToInt64(firstPart * Math.Pow(10, myKey));
                    return WriteNumber(firstPart) + thisSizeName + WriteNumber(secondPart);
                }
                return roundNumbersTillOneHundred[number / 10] + numbersTillTwenty[number % 10];
            }
            return numbersTillTwenty[number];
        }


        public int KeyByValue(Dictionary<int, string> dict, string val)
        {
            int key = default;
            foreach (KeyValuePair<int, string> pair in dict)
            {
                if (EqualityComparer<string>.Default.Equals(pair.Value, val))
                {
                    key = pair.Key;
                    break;
                }
            }
            return key - 1;
        }


        public long GetValue()
        {
            return Number;
        }

        public static int SumLetters(long number)
        {
            int countLetters = 0;
            for(long i =0; i<number; i++)
            {
                string numberInWords = number.ToString().Trim();
                Console.WriteLine(numberInWords);
                countLetters += numberInWords.Length;
            }
            return countLetters;
        }
    }
}
