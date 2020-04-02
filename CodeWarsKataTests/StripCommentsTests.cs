using NUnit.Framework;
using StripComments;

namespace CodeWarsKataTests
{
    public class StripCommentsTests
    {
        [Test]
        public void StripComments()
        {
            Assert.AreEqual("a\nc\nd", StripCommentsKata.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));

            Assert.AreEqual(
                "apples, pears\ngrapes\nbananas",
                StripCommentsKata.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));


        }
    }
}