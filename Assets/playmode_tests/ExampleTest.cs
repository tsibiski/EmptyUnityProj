using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace Unity.AutomatedQA.Tests
{
    public class ExampleTests
    {
        [UnitySetUp]
        public IEnumerator SetUp()
        {
            yield return null;
        }

        [UnityTest]
        [Timeout(900000)]
        public IEnumerator RunTests()
        {
            Assert.IsTrue(true, "Testing tests!");
            yield return null;
        }
    }
}