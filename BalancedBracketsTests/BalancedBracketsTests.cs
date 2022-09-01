using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
        //Test 1
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        // Test 2
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        // Test 3
        [TestMethod]
        public void StringInsideBracketsIsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }
        // Test 4
        [TestMethod]
        public void BracketsInsideStringIsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }
        // Test 5
        [TestMethod]
        public void BracketsInFrontofStringIsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }
        // Test 6
        [TestMethod]
        public void IsEmptyString()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        // Test 7
        [TestMethod]
        public void NestedBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }
        // Test 8
        [TestMethod]
        public void MissingBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Launchcode"));
        }
        // Test 9
        [TestMethod]
        public void ReverseBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("La]unchC[ode"));
        }
        // Test 10
        [TestMethod]
        public void SingleBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
        // Test 11
        [TestMethod]
        public void OppositeBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
        // Test 12
        [TestMethod]
        public void MixedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][[]"));
        }
    }
}
