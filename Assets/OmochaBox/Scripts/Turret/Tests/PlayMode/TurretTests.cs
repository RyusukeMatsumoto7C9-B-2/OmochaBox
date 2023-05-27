using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;


public class TurretTests
{
    private const string TEST_SCENE_NAME = "TurretTests";
    private const string TURRET_TARGET_NAME = "TurretTarget";

    
    [UnityTest]
    public IEnumerator Test_SetTarget_IsTargetExists_True()
    {
        SceneManager.LoadScene(TEST_SCENE_NAME);
        yield return new WaitForSeconds(1f);

        var turret = GameObject.FindObjectOfType<Turret>();
        var target = GameObject.Find(TURRET_TARGET_NAME);

        turret.SetTarget(target.transform);
        Assert.IsTrue(turret.IsTargetExists);
    }
}
