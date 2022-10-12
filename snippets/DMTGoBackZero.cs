using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * set the GO back when it falls down
 * also sets all velocities to zero (zero 3d vector)
 * usage: put script on GO
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */

public class DMTGoBackZero : MonoBehaviour
{

    private Vector3 myStartPos;     // speichern der Startposition
    private Rigidbody myRB;         // Rigidbody um Kraft (Force) auf 0 zu setzten

    void Start()
    {
        myStartPos = this.transform.position;
        myRB = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (this.transform.position.y < -10)
        {
            myRB.velocity = Vector3.zero;
            myRB.angularVelocity = Vector3.zero;
            this.transform.position = myStartPos;
        }
    }
}