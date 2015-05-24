/* ------------------+------+--------+-----------------------------
 Analyse Diamond D                                           
------------------+------+--------+--------------------------------
                  | left | length | middle => length-left-2 letters
------------------+------+--------+--------------------------------
Line 0 ---A	      | 3    | 4      | N/A
Line 1 --B-B	  | 2    | 5      | 1 
Line 2 -C---C	  | 1    | 6      | 3 
Line 3 D-----D	  | 0    | 7      | 5 
------------------+------+--------+-------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Diamond_Kata
{
    public class Diamond
    {
        private const char FirstLetter = 'A';
        private const char PaddingChar = ' ';
        private const string LineSeparator = "\n";

        public static string Create(char middleCharacter)
        {
            if (middleCharacter == FirstLetter) return "A";

            return FullDiamond(PrepareHalfDiamond(middleCharacter));
        }

        private static List<string> PrepareHalfDiamond(char middleCharacter)
        {
            var lines = new List<string>();
            int paddingLeft = middleCharacter - FirstLetter;
            int length = paddingLeft + 1;
            int paddingMiddle = 1;

            foreach (var character in Enumerable.Range('A', middleCharacter + 1 - 'A'))
            {
                lines.Add(PrepareDiamondLine(paddingLeft, character, paddingMiddle));

                paddingMiddle = ++length - --paddingLeft - 2;
            }
            return lines;
        }

        private static string FullDiamond(List<string> halfDiamondRaw)
        {
            var halfDiamond = string.Join(LineSeparator, halfDiamondRaw);
            halfDiamondRaw.Reverse();
            return halfDiamond + LineSeparator + string.Join(LineSeparator, halfDiamondRaw.Skip(1));
        }

        private static string PrepareDiamondLine(int paddingLeft, int character, int paddingMiddle)
        {
            var letter = Convert.ToChar(character);
            var line = string.Empty.PadLeft(paddingLeft, PaddingChar) + letter;

            if (letter != FirstLetter)
            {
                line += string.Empty.PadLeft(paddingMiddle, PaddingChar) + letter;
            }
            return line;
        }
    }
}