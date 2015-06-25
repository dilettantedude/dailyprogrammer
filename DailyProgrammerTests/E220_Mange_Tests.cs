using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DailyProgrammer;

namespace DailyProgrammerTests
{
    [TestClass]
    public class E220_Mange_Tests
    {
        [TestMethod]
        public void Mangle_Not_So_Hard()
        {
            string input = "This challenge doesn't seem so hard.";
            string output = "Hist aceeghlln denos't eems os adhr.";

            Assert.AreEqual(output, E220_Mangle.MangeSentence(input), "Failed to match mangled text");
        }

        [TestMethod]
        public void Heaven_And_Earth()
        {
            string input = "There are more things between heaven and earth, Horatio, than are dreamt of in your philosophy.";
            string output = "Eehrt aer emor ghinst beeentw aeehnv adn aehrt, Ahioort, ahnt aer ademrt fo in oruy hhilooppsy.";

            Assert.AreEqual(output, E220_Mangle.MangeSentence(input), "Failed to match mangled text");
        }
        [TestMethod]
        public void Eye_of_a_Newt()
        {
            string input = "Eye of Newt, and Toe of Frog, Wool of Bat, and Tongue of Dog.";
            string output = "Eey fo Entw, adn Eot fo Fgor, Loow fo Abt, adn Egnotu fo Dgo.";

            Assert.AreEqual(output, E220_Mangle.MangeSentence(input), "Failed to match mangled text");
        }
        [TestMethod]
        public void Adders_Fork()
        {
            string input = "Adder's fork, and Blind-worm's sting, Lizard's leg, and Howlet's wing.";
            string output = "Adder's fkor, adn Bdilm-nors'w ginst, Adilrs'z egl, adn Ehlost'w ginw.";

            Assert.AreEqual(output, E220_Mangle.MangeSentence(input), "Failed to match mangled text");
        }
        [TestMethod]
        public void For_a_charm()
        {
            string input = "For a charm of powerful trouble, like a hell-broth boil and bubble.";
            string output = "For a achmr fo eflopruw belortu, eikl a behh-llort bilo adn bbbelu.";

            Assert.AreEqual(output, E220_Mangle.MangeSentence(input), "Failed to match mangled text");
        }
    }
}
