using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

/*
 * 3D Object "Button" for scene switch
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 * 
 * usage: with gameobject
 */

public class DMTClickScene : MonoBehaviour
{
    public string whichScene;

    private void OnMouseDown()
    {
        if (whichScene != "")
        {
            Debug.LogWarning("Button pressed: change Scene > " + whichScene);
            SceneManager.LoadScene(whichScene);
        }
        else
            Debug.LogError("DMTButtonScene: no Scene Name specified!");
    }
}
