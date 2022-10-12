using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * show or hide mouse cursor
 * usage: put on a gameObject (GO) 
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, Nischelwitzer 2019
 * www.fh-joanneum.at
 */

public class DMTCursorOnOff : MonoBehaviour
{
    [Header("Show/hide mouse cursor and set LockState")]

    [Tooltip("True (1) to show mouse cursor or false (0, unchecked) to hide it.")]
    public bool showCursor = true;

    void Awake()
    {
      
        if (showCursor)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        Debug.Log("MouseCursor: " + (showCursor ? "is shown and not locked":"is locked (and hidden)") + " in GO: "+this.gameObject.name);
    }

}