using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * set the GO to dontdestroyonload
 * usage: put script on GO which should be always in all scenes
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */

public class DMTDontDestroy : MonoBehaviour
{

    void Start()
    {
        Debug.Log("##### DMTDontDestroy Start: " + this.gameObject.name + " " + this.gameObject.GetType().ToString());
        DontDestroyOnLoad(this);
    }

}