using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Rotate Camera with mouse
 * usage: put script on (main) camera
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */

public class DMTCamRotMouse : MonoBehaviour
{

    void Start()
    {
        Debug.Log("##### Camera Rotates with Mouse: " + this.gameObject.name + " " + this.gameObject.GetType().ToString());

        if (this.GetComponent<Camera>() == null)
        {
            Debug.LogError("##### Script is not on a Camera: in on GO "+this.gameObject.name);
        }
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        float x = 5 * Input.GetAxis("Mouse X");
        float y = 5 * -Input.GetAxis("Mouse Y");
        this.transform.Rotate(y, x, 0);
    }
}