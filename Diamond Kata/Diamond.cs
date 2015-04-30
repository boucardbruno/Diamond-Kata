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
    }

    public class Diamond
    {
        public static string Create(char c)
        {
            return "A";
        }
    }
}
