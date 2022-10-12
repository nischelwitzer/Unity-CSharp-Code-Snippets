using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMTConsoleLog : MonoBehaviour {

    public string infoString;
    private int cntAnim = 0;

    // Use this for initialization
    void Start()
    {
        Debug.Log("##### Start: DMT_ConsoleLog" + this.gameObject.name);
    }

    private void OnMouseDown()
    {
        cntAnim++;
        Debug.Log("##### ConsoleLog: "+ infoString+ " >> "+cntAnim);
    }

}
