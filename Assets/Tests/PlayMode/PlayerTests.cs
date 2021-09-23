using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEngine.SceneManagement;

public class PlayerTests
{

    [OneTimeSetUp]
    public void LoadScene()
    {
        SceneManager.LoadScene("Gameplay");
    }

    [UnityTest]
    public IEnumerator TestIfPlayerSpawns()
    {
        GameObject player = GameObject.Find("SpawnedPlayer");
        yield return null;
        Assert.NotNull(player);
    }
    /*
    [UnityTest]
    public IEnumerator TestIfPlayerJumps()
    {
        GameObject player = GameObject.Find("SpawnedPlayer");


        float posicionInicialY = player.transform.position.y;

        player.GetComponent<PlayerMovement>().Jump();

        yield return null;
        yield return null;

        float posicionFinalY = player.transform.position.y;


        Assert.AreNotEqual(posicionFinalY,posicionInicialY);
    }
 */   
}
