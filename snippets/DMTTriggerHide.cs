using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Simple Trigger and Hide Script
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */

public class DMTTriggerHide : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // this.gameObject.SetActive(false);
        this.gameObject.GetComponent<MeshRenderer>().enabled = false; // hide renderer
        Destroy(this.gameObject, 2.0F); // destroy (a little later to hear sound)

        Debug.Log("##### DMTTriggerHide GameObject (GO): " + this.gameObject.name + " <> " + other.name);
    }
}
