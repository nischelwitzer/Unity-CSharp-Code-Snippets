using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMTButtonQuit : MonoBehaviour
{
    public void ButtonPressQuit()
    {
        Debug.LogWarning("Button pressed: quit application!");
        Application.Quit();
    }
}
