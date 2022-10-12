using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * plays the audiosource on trigger 
 * usage: put on GO with audio source and collider with trigger
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */

public class DMTTriggerAudio : MonoBehaviour
{

    private AudioSource myAudio;

    private void Start()
    {
        myAudio = this.GetComponent<AudioSource>();
        Debug.Log("##### DMTPlayAudio Start: " + this.gameObject.name + " " + this.gameObject.GetType().ToString());
    }

    private void OnTriggerEnter(Collider other)
    {
        myAudio.Play();
        Debug.Log("##### DMTTriggerAudio PLAY GameObject (GO): " + this.gameObject.name + " <> " + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        myAudio.Stop();
        Debug.Log("##### DMTTriggerAudio PLAY GameObject (GO): " + this.gameObject.name + " <> " + other.name);
    }

}

