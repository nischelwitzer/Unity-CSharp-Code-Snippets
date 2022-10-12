using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMTKeyGoXYZ : MonoBehaviour
{
    public KeyCode whichKey;
    public Transform myPos;

    void Update()
    {
        if (Input.GetKeyDown(whichKey))
        {
            this.transform.position = myPos.position;
            // this.transform.position = new Vector3(0, 0, 0);
            Debug.Log("##### Key " + whichKey + " set " + this.name + " to " + this.transform.position);
        }
    }

}
