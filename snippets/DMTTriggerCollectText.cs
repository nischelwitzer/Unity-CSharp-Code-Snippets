using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

/*
 * Trigger and Count and Hide Script
 * if trigger gets fired > count one point, write in TMProUI Text and hide object
 * 
 * usage: needs a TextMeshPRO UI Elemente with Startstring "0" (Zero)
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */


public class DMTTriggerCollectText : MonoBehaviour
{
    public TextMeshProUGUI pointText;

    private void OnTriggerEnter(Collider other)
    {
        int nowPoints = int.Parse(pointText.text);
        pointText.text = (nowPoints + 1).ToString();

        Debug.Log("##### DMTTriggerAudio DESTROY GameObject (GO): " + this.gameObject.name + " <> " + other.name);

        // this.gameObject.SetActive(false);
        // this.gameObject.active = false;

        this.gameObject.GetComponent<MeshRenderer>().enabled = false; // hide renderer
        Destroy(this.gameObject, 2.0F); // destroy (a little later to hear sound)
    }


}
