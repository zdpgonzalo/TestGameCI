using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class SimpleTest : MonoBehaviour
{
    [Test]
    public void SimpleTestSimplePasses()
    {
        Assert.AreEqual(2+2, 4);
    }
}
