using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMTRotateMe : MonoBehaviour
{

    public int doRotateX = 3;
    public int doRotateY = 4;
    public int doRotateZ = 5;

    // Use this for initialization
    void Start()
    {
        Debug.Log("##### RotateMe Script started");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(doRotateX, doRotateY, doRotateZ);
    }
}
