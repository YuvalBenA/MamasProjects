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
            if (Number < 20)
            {
                return UnderTwenty(copyNumber);
            }
            else if (Number < 100)
            {
                return UnderOneHundred(copyNumber);
            }
            else if (Number < 1000)
            {
                return UnderOneThousand(copyNumber);
            }
            else if (Number < 20000)
            {
                return UnderTwentyThousand(copyNumber);
            }
            else if (Number < 100000)
            {
                return UnderOneHundredThousand(copyNumber);
            }
            else if (Number < 1000000)
            {
                return UnderOneMillion(copyNumber);
            }
            else if (Number < 20000000)
            {
                return UnderTwentyMillion(copyNumber);
            }
            else if (Number < 100000000)
            {
                return UnderOneHundredMillion(copyNumber);
            }
            else if(Number < 1000000000)
            {
                return UnderOneBillion(copyNumber);
            }
            else if (Number < 20000000000)
            {
                return UnderTwentyBillion(copyNumber);
            }
            else if (Number < 100000000000)
            {
                return UnderOneHundredBillion(copyNumber);
            }
            else if (Number < 1000000000000)
            {
                return UnderOneTrillion(copyNumber);
            }
            else
            {
                return "Number out of range. "; 
            }
        }


        public string UnderTwenty(long number)
        {
            if (number == 0)
            {
                return "";
            }
            string[] numbersTillTwenty = { "zero ", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine ","ten ",
            "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen ","eighteen ", "ninteen "};
            return numbersTillTwenty[number];
        }


        public string UnderOneHundred(long number)
        {
            if (number == 0)
            {
                return "";
            }
            if (number < 20)
            {
                return "and " + UnderTwenty(number);
            }
            string[] roundNumbersTillOneHundred = { "zero ", "ten ", "twenty ", "thirty ", "fourty ", "fifty ", "sixty ", "seventy ", "eighty ", "ninety " };
            return roundNumbersTillOneHundred[number / 10] + UnderTwenty(number % 10);
        }

        public string UnderOneThousand(long number)
        {
            if (number == 0)
            {
                return "";
            }
            if (number < 100)
            {
                return UnderOneHundred(number);
            }
            return UnderTwenty(number / 100) + "hundred " + UnderOneHundred(number % (number / 100 * 100));
        }

        public string UnderTwentyThousand(long number)
        {
            if (number == 0)
            {
                return "";
            }
            return UnderTwenty(number / 1000) + "thousand " + UnderOneThousand(number % (number / 1000 * 1000));
        }

        public string UnderOneHundredThousand(long number)
        {
            if (number == 0)
            {
                return "";
            }
            return UnderOneHundred(number / 1000) + "thousand " + UnderOneThousand(number % (number / 1000 * 1000));
        }

        public string UnderOneMillion(long number)
        {
            if (number == 0)
            {
                return "";
            }
            return UnderOneThousand(number / 1000) + "thousand " + UnderOneThousand(number % (number / 1000 * 1000));
        }

        public string UnderTwentyMillion(long number)
        {
            if (number == 0)
            {
                return "";
            }
            return UnderTwenty(number / 1000000) + "million " + UnderOneMillion(number % (number / 1000000 * 1000000));
        }
        public string UnderOneHundredMillion(long number)
        {
            if (number == 0)
            {
                return "";
            }
            return UnderOneHundred(number / 1000000) + "million " + UnderOneMillion(number % (number / 1000000 * 1000000));
        }
        public string UnderOneBillion(long number)
        {
            if (number == 0)
            {
                return "";
            }
            return UnderOneThousand(number / 1000000) + "million " + UnderOneMillion(number % (number / 1000000 * 1000000));
        }

        public string UnderTwentyBillion(long number)
        {
            if (number == 0)
            {
                return "";
            }
            return UnderTwenty(number / 1000000000) + "billion " + UnderOneBillion(number % (number / 1000000000 * 1000000000));
        }
        public string UnderOneHundredBillion(long number)
        {
            if (number == 0)
            {
                return "";
            }
            return UnderOneHundred(number / 1000000000) + "billion " + UnderOneBillion(number % (number / 1000000000 * 1000000000));
        }
        public string UnderOneTrillion(long number)
        {
            if (number == 0)
            {
                return "";
            }
            return UnderOneThousand(number / 1000000000) + "billion " + UnderOneBillion(number % (number / 1000000000 * 1000000000));
        }
    }
}
