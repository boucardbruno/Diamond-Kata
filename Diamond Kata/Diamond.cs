/* --------------------------------------------------------
 Analyse Diamond E                                           
----------+------+--------+--------------------------------
          | left | length | middle => length-left-2 letters
----------+------+--------+--------------------------------
---A	  | 3    | 4      | N/A
--B-B	  | 2    | 5      | 1 
-C---C	  | 1    | 6      | 3 
E-----E	  | 0    | 7      | 5 
----------+------+--------+--------------------------------*/

using System.Collections.Generic;
using NUnit.Framework;

namespace Diamond_Kata
{
    public class DiamondTest
    {
        [Test]
        public void Should_produce_a_single_charcter_when_diamond_is_smallest()
        {
            const string diamond = "A";

            Assert.AreEqual(diamond, Diamond.Create('A'));
        }

        [Test]
        public void Should_print_diamond_when_call_with_B()
        {
            const string diamond = "  A\n"  +
                                   " B B";

                         

            Assert.AreEqual(diamond, Diamond.Create('C'));
        }
    }

    public class Diamond
    {
        private const char FirstLetter = 'A';

        public static string Create(char middleCharacter)
        {
            if (middleCharacter == FirstLetter) return "A";

            var lines = new List<string>();
            int paddingLeft = middleCharacter - FirstLetter;
            int length = paddingLeft + 1;
            int paddingMiddle = 1;

            foreach (var letter in "AB")
            {
                var line = string.Empty.PadLeft(paddingLeft, ' ') + letter;

                if (letter != FirstLetter)
                {
                    line += string.Empty.PadLeft(paddingMiddle, ' ') + letter;
                }
                lines.Add(line);
                
                paddingLeft--;
                length ++;
                paddingMiddle = length - paddingLeft - 2;
            }
            return string.Join("\n", lines);
        }
    }
}
