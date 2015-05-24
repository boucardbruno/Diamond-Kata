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
            const string diamond = " A\n" +
                                   "B B\n" +
                                   " A";
            Assert.AreEqual(diamond, Diamond.Create('B'));
        }

        [Test]
        public void Should_print_diamond_when_call_with_C()
        {
            const string diamond = "  A\n" +
                                   " B B\n" +
                                   "C   C\n" +
                                   " B B\n" +
                                   "  A";
            Assert.AreEqual(diamond, Diamond.Create('C'));
        }

        [Test]
        public void Should_print_diamond_when_call_with_D()
        {
            const string diamond = "   A\n" +
                                   "  B B\n" +
                                   " C   C\n" +
                                   "D     D\n" +
                                   " C   C\n" +
                                   "  B B\n" +
                                   "   A";
            Assert.AreEqual(diamond, Diamond.Create('D'));
        }
    }
}