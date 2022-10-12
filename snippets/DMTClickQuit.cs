using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Click and Quite Application
 * usage: put on 3D GO
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */

public class DMTClickQuit : MonoBehaviour {

    private void Start()
    {
        Debug.Log("##### Click and Quit: "+ this.gameObject.name);
    }

    private void OnMouseDown()
    {
        Debug.LogWarning("3D Gameobject (GO) pressed: quit application!");
        Application.Quit();
    }

}
