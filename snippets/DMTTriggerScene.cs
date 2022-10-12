using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Simple Trigger and switch scene
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */

public class DMTTriggerScene : MonoBehaviour
{
    public string whichScene;

    private void OnTriggerEnter(Collider other)
    {

        if (whichScene != "")
        {
            Debug.LogWarning("Trigger fired: change Scene > " + whichScene);
            SceneManager.LoadScene(whichScene);
        }
        else
            Debug.LogError("DMTTriggerScene: no Scene Name specified!");

    }
}
