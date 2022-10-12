using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class DMTVideoCtrl : MonoBehaviour
{

    public enum VideoController // your custom enumeration
    {
        Play,
        Pause,
        Stop,
        Toggle
    };

    public GameObject videoSource;
    public VideoController myControls = VideoController.Play;
    private VideoPlayer myVideoPlayer;

    void Start()
    {
        Debug.Log("##### DMTPlayVideoGO Start: " + this.gameObject.name + " " + this.gameObject.GetType().ToString());

        myVideoPlayer = videoSource.GetComponent<UnityEngine.Video.VideoPlayer>();

        if (myVideoPlayer == null)
        {
            Debug.LogError("##### DMTVideoCtrl has no VideoPlayer as target: " + this.gameObject.name);
        }
    }

    void OnMouseDown()
    {

        if (myControls == VideoController.Play) myVideoPlayer.Play();
        if (myControls == VideoController.Pause) myVideoPlayer.Pause();
        if (myControls == VideoController.Stop) myVideoPlayer.Stop();

        if (myControls == VideoController.Toggle)
            if (myVideoPlayer.isPlaying)
            {
                Debug.Log("GameObject TOGGLE/PAUSE Button for Video pressed: " + videoSource.name);
                myVideoPlayer.Pause();
            }
            else
            {
                Debug.Log("GameObject TOGGLE/PLAY Button for Video pressed: " + videoSource.name);
                myVideoPlayer.Play();
            }
    }
}
