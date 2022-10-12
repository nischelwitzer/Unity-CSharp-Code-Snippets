using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * plays the audiosource on a 3D GO
 * usage: put on GO with audio source
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */

public class DMTPlayAudioGO : MonoBehaviour
{

    public GameObject audioTarget;
    private AudioSource myAudio;

    private void Start()
    {
        myAudio = audioTarget.GetComponent<AudioSource>();
        Debug.Log("##### DMTPlayAudio Start: " + this.gameObject.name + " " + this.gameObject.GetType().ToString());
    }

    private void OnMouseDown()
    {

        if (myAudio.isPlaying)
        {
            myAudio.Pause();
            Debug.Log("##### DMTPlayAudio PAUSE GameObject (GO) pressed on: " + this.gameObject.name);
        }
        else
        {
            myAudio.Play();
            Debug.Log("##### DMTPlayAudio PLAY GameObject (GO) pressed on: " + this.gameObject.name);
        }

    }
}
