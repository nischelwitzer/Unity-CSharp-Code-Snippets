using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

/*
 * shows and hides a GO on trigger event
 * usage: put on GO with with trigger
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, Nischelwitzer 2019
 * www.fh-joanneum.at
 */

public class DMTTriggerShowToggle : MonoBehaviour
{

    [Header("Toggle GO when trigger is fired")]

    [Tooltip("GameObject to show/hide")]
    public GameObject workGO;

    void Start()
    {
        if (workGO != null)
        {
            workGO.gameObject.SetActive(false);
            Debug.Log("##### DMTTriggerShowToggle Start: TriggerGO > " + this.gameObject.name + " " + this.gameObject.GetType().ToString());
            Debug.Log("##### DMTTriggerShowToggle Start: WorkGO   >" + workGO.name + " " + workGO.GetType().ToString());
        }
        else
            Debug.LogError("Trigger missing GO on Show/Hide " + this.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (workGO != null)
        {
            workGO.gameObject.SetActive(true);
        }
        else
            Debug.LogError("Trigger missing GO on Show/Hide " + this.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        if (workGO != null)
        {
            workGO.gameObject.SetActive(false);
        }
        else
            Debug.LogError("Trigger missing GO on Show/Hide " + this.gameObject.name);
    }

}

