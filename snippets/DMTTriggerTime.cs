using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/*
 * time with trigger 
 * show clock time in ms and round time (and rounds)
 * usage: put on GO with collider/trigger, needs two TMP UI TextElements as time displays
 * 
 * Author: DMT Team, FH JOANNEUM, IMA,´DMT, Alexander Nischelwitzer
 * last changed: 22.12.2019
 * www.fh-joanneum.at IMA - digital media technologies
 */

namespace DMT
{
    /// <summary>
    /// DMTTriggerTime for calculating round time and clock time
    /// </summary>
    /// 
    /// <remarks>
    /// two textmeshpro UI textelements to show roundtime and clocktime
    /// </remarks>

    public class DMTTriggerTime : MonoBehaviour
    {
        [Header("Take Time with Trigger")]

        [Tooltip("TextMeshPro UI Text for Stop Time Display")]
        public TextMeshProUGUI timeText;

        [Tooltip("TextMeshPro UI Text for Clock Time Display")]
        public TextMeshProUGUI clockText;

        private float myStartTime;
        private float myRoundTime;
        private int myRound = 0;

        private void Start()
        {
            myStartTime = Time.time;    // calculates the total time since sceen start
            myRoundTime = myStartTime;  // calculates the time for every round

            Debug.Log("##### DMTTriggerTime Start: " + this.gameObject.name + " " + this.gameObject.GetType().ToString());
        }

        private void Update()
        {
            #region show clock time from scenestart
            float nowTime = Time.time - myStartTime;
            float roundTime = Time.time - myRoundTime;

            if (clockText != null)
                clockText.text = Mathf.Round(nowTime * 1000) + " msec \n" +
                    Mathf.Round(roundTime * 1000) + " msec " + "[" + myRound + "]";  
            else
                Debug.LogWarning("!!!!! no ClockText (TextMeshPro) found");
            #endregion
        }

        private void OnTriggerEnter(Collider other)
        {
            #region calculate RoundTime when trigger is fired
            float nowTime = Time.time - myRoundTime;
            myRound++;

            if (timeText != null)
                timeText.text = Mathf.Round(nowTime * 1000) + " msec \nRound: " + myRound;
            else
                Debug.LogWarning("!!!!! no TimeText (TextMeshPro) found");

            #endregion
            Debug.Log("##### DMTTriggerTime: " + (nowTime * 1000));
        }

        private void OnTriggerExit(Collider other)
        {
            myRoundTime = Time.time;
            Debug.Log("##### DMTTriggerTime start: " + (myStartTime * 1000) + " ms");
        }

    }
}

