using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

/*
 * plays the videosource on trigger 
 * usage: put on GO with with trigger
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, Nischelwitzer 2019
 * www.fh-joanneum.at
 */

public class DMTTriggerVideo : MonoBehaviour
{

    [Header("Play Video when trigger is fired")]

    [Tooltip("GameObject with VideoPlayer to Control")]
    public GameObject videoSource;

    private VideoPlayer vp;

    void Start()
    {
        if (videoSource != null)
        {
            vp = videoSource.GetComponent<VideoPlayer>();
            Debug.Log("##### DMTTriggerVideo Start: TriggerGO > " + this.gameObject.name + " " + this.gameObject.GetType().ToString());
            Debug.Log("##### DMTTriggerVideo Start: VideoGO   >" + videoSource.name + " " + videoSource.GetType().ToString());
        }
        else
            Debug.LogError("Trigger missing VideoSource GO on TriggerGO " + this.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (vp != null)
        {
            vp.Play();
            Debug.Log("Trigger VideoPlayer play: " + videoSource.name);
        }
        else
            Debug.LogError("Trigger VideoPlayer missing Video with Trigger " + this.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        vp.Pause();
        Debug.Log("Trigger VideoPlayer pause: " + videoSource.name);
    }
}

