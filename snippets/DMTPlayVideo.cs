using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * scripts plays and pause video (toggle button)
 * usage: put it on the videoplayer gameobject
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */

public class DMTPlayVideo : MonoBehaviour {
   
    void OnMouseDown()
    {
        Debug.Log("GameObject pressed: "+ this.name );
        var videoPlayer = this.GetComponent<UnityEngine.Video.VideoPlayer>();

        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
        else
        {
            videoPlayer.Play();
        }
    }
}
