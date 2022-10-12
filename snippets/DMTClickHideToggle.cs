using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Simple Click and toggle GO 
 * usage: put the script on a 3d gameobject for interaction and drop the "hide gameobject" in the script field
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS
 * www.fh-joanneum.at
 */

public class DMTClickHideToggle : MonoBehaviour
{

    public GameObject hideThisGameObject;

    private void Start()
    {
        Debug.Log("##### Click and Hide other: " + this.gameObject.name);

        if (hideThisGameObject == null)
        {
            Debug.LogError("##### no Game to hide defined in " + this.gameObject.name);
        }
    }

    private void OnMouseDown()
    {
        if (hideThisGameObject != null)
        {
            if (hideThisGameObject.activeSelf)
            {
                Debug.Log("##### SetActive FALSE for: " + hideThisGameObject.gameObject.name);
                hideThisGameObject.SetActive(false);
            }
            else
            {
                Debug.Log("##### SetActive TRUE for: " + hideThisGameObject.gameObject.name);
                hideThisGameObject.SetActive(true);
            }
        }
        else
            Debug.LogWarning("!!!!! no GameObject in DMTClickHideOther defined!");
    }

}
