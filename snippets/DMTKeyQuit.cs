using UnityEngine;
using System.Collections;

// Quits the player when the user hits escape

public class DMTKeyQuit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Debug.LogWarning("##### ESC pressed: quit application!");
            Application.Quit();
        }
    }

}