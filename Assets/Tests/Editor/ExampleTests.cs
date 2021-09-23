using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class ExampleTests
{
    [Test]
    public void Test()
    {
        int a = 10;
        Assert.AreEqual(a, 10);
    }

    [Test]
    public void TestPlayerDamage()
    {
        GameObject gameObject = new GameObject("GameObject");

        PlayerController player = gameObject.AddComponent<PlayerController>();

        player.HP = 100;

        player.TakeDamage(50);

        Assert.AreEqual(player.HP, 50);
    }

    
    
}
