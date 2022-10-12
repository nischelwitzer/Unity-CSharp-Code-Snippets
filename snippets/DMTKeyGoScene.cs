using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/*
 * press key to go to another scene
 * usage: put on a gameObject and define the key and the scene to go
 *        also include the scene in the build settings
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, Nischelwitzer 2019
 * www.fh-joanneum.at
 */


public class DMTKeyGoScene : MonoBehaviour
{
    [Header("Change to a scene when key is pressed")]

    [Tooltip("Key to fire the scene change")]
    public KeyCode whichKeyToPress;
    
    [Tooltip("Name from Scene where to go.")]
    public string sceneName;

    void Update()
    {
        if (Input.GetKeyDown(whichKeyToPress))
        {

            if (sceneName != "")
            {
                Debug.Log("DMTScene: SceneManagement go to > " + sceneName);
                SceneManager.LoadScene(sceneName);
            }
            else
                Debug.LogError("DMTScene: no Scene Name specified!");

        }
    }

}
