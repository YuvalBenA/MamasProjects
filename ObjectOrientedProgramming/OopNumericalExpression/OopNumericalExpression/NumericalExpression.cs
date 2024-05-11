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
            if (number >= 20)
            {
                if (number >= 100)
                {
                    int numbersLength = (int)(Math.Log10(number)+1);
                    int raiseTenBy = KeyByValue(sizeName, numbersSizeName[numbersLength]);
                    long numbersFirstPart = Convert.ToInt64( Math.Floor((number / Math.Pow(10, raiseTenBy))));
                    string thisSizeName = sizeName[(int)(Math.Log10(number)+1)];
                    long numbersSecondPart = number - Convert.ToInt64(numbersFirstPart * Math.Pow(10, raiseTenBy));
                    return WriteNumber(numbersFirstPart) + thisSizeName + WriteNumber(numbersSecondPart);
                }
                return roundNumbersTillOneHundred[number / 10] + WriteNumber(number % 10);
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
                NumericalExpression iAsNumericalExpression = new NumericalExpression(i);
                string numberInWords = iAsNumericalExpression.ToString().Trim();
                countLetters += numberInWords.Length;
            }
            return countLetters;
        }

        public static int SumLetters(NumericalExpression number)
        {
            //polymorphism הוא העקרון שמתממש פה כי נותנים שימוש זהה לפונקציה עם חתימה שונה
            long thisNumber = number.GetValue();
            return SumLetters(thisNumber);
        }
    }
}
