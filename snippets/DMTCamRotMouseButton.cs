using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMTCamRotMouseButton : MonoBehaviour
{

    void Start()
    {
        Debug.Log("##### Camera Rotates with Mouse & Button: " + this.gameObject.name + " " + this.gameObject.GetType().ToString());

        if (this.GetComponent<Camera>() == null)
        {
            Debug.LogError("##### Script is not on a Camera: in on GO " + this.gameObject.name);
        }
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0)) // primary button - win "left"
        {
            float x = 5 * Input.GetAxis("Mouse X");
            float y = 5 * -Input.GetAxis("Mouse Y");
            this.transform.Rotate(y, x, 0);
            Debug.Log(">>>>> MouseButton and Rotate");
        }
    }
}