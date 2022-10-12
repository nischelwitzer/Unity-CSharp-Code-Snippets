using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Scripts to switch scene or quit app
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 * 
 * usage: with buttons (canvas)
 */

public class DMTButtonScene : MonoBehaviour
{

    void Start()
    {
        Debug.Log("DMTButtonScene Management loaded");
    }

    void Update()
    {

    }

    public void DMT_GoScene(string whichScene)
    {
        if (whichScene != "")
        {
            Debug.Log("DMTButtonScene: SceneManagement go to > " + whichScene);
            SceneManager.LoadScene(whichScene);
        }
        else
            Debug.LogError("DMTButtonScene: no Scene Name specified!");
    }

    public void DMT_QuitApp()
    {
        Debug.LogWarning("Quit Button pressed: quit application!");
        Application.Quit();
    }

}
