using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Simple Click and Hide Script
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */

public class DMTClickHide : MonoBehaviour {

    private void Start()
    {
        Debug.Log("##### Click and Hide: "+ this.gameObject.name);
    }

    private void OnMouseDown()
    {
        Debug.Log("##### SetActive false for: " + this.gameObject.name);
        this.gameObject.SetActive(false);
    }

}
