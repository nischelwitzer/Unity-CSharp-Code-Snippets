using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMTGoBack : MonoBehaviour
{

    private Vector3 myStartPos;

    void Start()
    {
        myStartPos = this.transform.position;
    }

    void Update()
    {
        if (this.transform.position.y < -10)
            this.transform.position = myStartPos;
    }
}
