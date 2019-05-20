using Code;
using NUnit.Framework;

namespace Test
{
    public class DerivedClassTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DerivedClass()
        {
            DerivedClass B = new DerivedClass();
            B.DoWork();  // Calls the new method.

            BaseClass A = (BaseClass)B;
            A.DoWork();  // Calls the old method.
            Assert.Pass();
        }
    }
}