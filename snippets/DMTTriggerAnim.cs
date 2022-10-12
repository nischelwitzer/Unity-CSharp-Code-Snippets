
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * trigger animation
 * usage: collider with trigger
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */

public class DMTTriggerAnim : MonoBehaviour
{
    private Animator anim;
    public GameObject goAnimation;

    void Start()
    {
        anim = goAnimation.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (null != anim)
        {
            // play Bounce but start at a quarter of the way though
            anim.Play("Cube", 0, 0f);
        }

        Debug.Log("##### DMTTriggerAnimation PLAY GameObject (GO): " + this.gameObject.name + " <> " + other.name);
    }

}