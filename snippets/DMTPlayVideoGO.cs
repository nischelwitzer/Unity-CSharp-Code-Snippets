using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMTPlayVideoGO : MonoBehaviour {

    public GameObject videoSource;

	void Start () {
        Debug.Log("##### DMTPlayVideoGO Start: " + this.gameObject.name + " " + this.gameObject.GetType().ToString());
    }

    void OnMouseDown()
    {
        
        var vp = videoSource.GetComponent<UnityEngine.Video.VideoPlayer>();

        if (vp.isPlaying)
        {
            Debug.Log("GameObject PAUSE Button for Video pressed: " + videoSource.name);
            vp.Pause();
        }
        else
        {
            Debug.Log("GameObject PLAY Button for Video pressed: " + videoSource.name);
            vp.Play();
        }
    }
}
