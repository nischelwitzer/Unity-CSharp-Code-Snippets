using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * set the GO back when it falls down
 * usage: put script on GO
 * parameter: depth for falling
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */

public class DMTBack : MonoBehaviour
{

    private Vector3 myStartPos;     // speichern der Startposition
    private Rigidbody myRB;         // Rigidbody um Kraft (Force) auf 0 zu setzten

    public int posPutBack = -10; 

    void Start()
    {
        myStartPos = this.transform.position;
        myRB = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (this.transform.position.y < posPutBack)
        {
            myRB.velocity = Vector3.zero;
            myRB.angularVelocity = Vector3.zero;
            this.transform.position = myStartPos;
        }
    }
}