using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ExampleEditModeTest1
{
    // A Test behaves as an ordinary method
    [Test]
    public void ExampleEditModeTest1SimplePasses()
    {
        Assert.IsTrue(true, "Testing tests!");
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator ExampleEditModeTest1WithEnumeratorPasses()
    {
        Assert.IsTrue(true, "Testing tests!");
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
