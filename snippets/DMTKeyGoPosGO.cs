using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMTKeyGoPosGO : MonoBehaviour
{
    [Header("Change GameObject Position with Key")]

    [Tooltip("Key to change position")]
    public KeyCode whichKeyToPress;

    [Tooltip("Gameobject for Position & Rotation")]
    public GameObject newPositionFromGO;

    void Update()
    {
        if (Input.GetKeyDown(whichKeyToPress))
        {

            this.transform.position = newPositionFromGO.transform.position;
            this.transform.rotation = newPositionFromGO.transform.rotation;

            if (this.GetComponent<Rigidbody>() != null)
            {
                this.GetComponent<Rigidbody>().velocity = Vector3.zero;
                this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            }

            // this.transform.position = new Vector3(0, 0, 0);
            Debug.Log("##### Key " + whichKeyToPress + " set " + this.name + " to " + this.transform.position);
        }
    }

}
