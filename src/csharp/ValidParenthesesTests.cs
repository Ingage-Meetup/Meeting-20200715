using NUnit.Framework;
using ValidParentheses;

namespace AllProjects.Test
{
    [TestFixture]
    public class ValidParenthesesTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldHandleSingleParentheses()
        {
            Assert.AreEqual(true, Challenge.ValidParentheses("()"));
            Assert.AreEqual(false, Challenge.ValidParentheses(")"));
            Assert.AreEqual(false, Challenge.ValidParentheses("("));
        }
        [Test]
        public void ShouldHandleMultipleParantheses()
        {
            Assert.AreEqual(true, Challenge.ValidParentheses("()()"));
            Assert.AreEqual(false, Challenge.ValidParentheses("())"));
            Assert.AreEqual(true, Challenge.ValidParentheses("(())"));
            Assert.AreEqual(false, Challenge.ValidParentheses(")())"));
        }
        [Test]
        public void ShouldHandleComplexCases()
        {
            Assert.AreEqual(true, Challenge.ValidParentheses("((((()))))"));
            Assert.AreEqual(false, Challenge.ValidParentheses("()()()())"));
            Assert.AreEqual(true, Challenge.ValidParentheses("(()()()())(())"));
            Assert.AreEqual(false, Challenge.ValidParentheses("(((((((("));
            Assert.AreEqual(true, Challenge.ValidParentheses("(())((()((()))))"));
            Assert.AreEqual(false, Challenge.ValidParentheses("())("));
            Assert.AreEqual(false, Challenge.ValidParentheses(")()()()("));
            Assert.AreEqual(false, Challenge.ValidParentheses("(()()))("));
            Assert.AreEqual(false, Challenge.ValidParentheses(")()("));
        }
    }
}