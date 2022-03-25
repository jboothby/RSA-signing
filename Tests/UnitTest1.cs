using System;
using System.Diagnostics;
using NUnit.Framework;
using static Sign.Processor;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestEulersTotient()
    {
        Assert.True(EulersTotient(11, 13) == 120);
    }

    [Test]
    public void InverseProducesProperResults()
    {
        Assert.That(EuclideanInverse(7, 11), Is.EqualTo(8));
        Assert.AreEqual(118, EuclideanInverse(100, 171));
        Assert.AreEqual(3491, EuclideanInverse(123, 4568));
    }

    [Test]
    public void TestMillerRabinPrimality()
    {
        Assert.True(IsPrime(7));
        Assert.True(IsPrime(11));
        Assert.True(IsPrime(173));
        Assert.True(IsPrime(65537));

        Assert.False(IsPrime(4));
        Assert.False(IsPrime(171));
        Assert.False(IsPrime(333));
        Assert.False(IsPrime(808080808));
    }
}


//     [Test]
//     public void FastExponentationFasterThanPowerFunction()
//     {
//         var fastWatch = new Stopwatch();
//         var powerWatch = new Stopwatch();
//         
//         fastWatch.Start();
//         var fastResult = FastModularExponent(3, 35, 1234567);
//         fastWatch.Stop();
//         
//         powerWatch.Start();
//         var powResult = Math.Pow(3f, 35f) % 1234567;
//         powerWatch.Stop();
//         
//         Assert.Less(fastWatch.ElapsedTicks, powerWatch.ElapsedTicks);
//     }
// }