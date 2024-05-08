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

        public string ToString()
        {

            long copyNumber = Number;
            if (Number < 1000000000000)
            {
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
            if (number>20)
            {
                if (number > 100)
                {
                    if (number > 1000)
                    {
                        if (number > 1000000)
                        {
                            if (number > 1000000000)
                            {
                                return WriteNumber(number / 1000000000) + "billion " + WriteNumber(number % (number / 1000000000 * 1000000000));
                            }
                            return WriteNumber(number / 1000000) + "million " + WriteNumber(number % (number / 1000000 * 1000000));
                        }
                        return WriteNumber(number / 1000) + "thousand " + WriteNumber(number % (number / 1000 * 1000));

                    }
                    return WriteNumber(number / 100) + "hundred " + WriteNumber(number % (number / 100 * 100));
                }

                return roundNumbersTillOneHundred[number / 10] + WriteNumber(number % 10);
            }      
            return numbersTillTwenty[number];
        }
    }
}
