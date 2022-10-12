using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMTKeyToggleActive : MonoBehaviour
{

    public KeyCode whichKey;
    public GameObject whichGameObject;

    void Update()
    {
        if (Input.GetKeyDown(whichKey))
        {
            whichGameObject.SetActive(!whichGameObject.activeSelf);
            Debug.Log("##### Key "+whichKey+ " Toggle Active: " + whichGameObject.name+ " now " + whichGameObject.activeSelf);
            
        }
    }


} 