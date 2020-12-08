using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrigg;
    public GameObject HalfLapTrigg;

    public GameObject minuteDisplay;
    public GameObject secondDisplay;
    public GameObject milliDisplay;

    public GameObject LapTimeBox;
    private void OnTriggerEnter()
    {
        if(LapTimeManager.secondCount <= 9)
        {
            secondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.secondCount + ".";
        } else
        {
            secondDisplay.GetComponent<Text>().text = "" + LapTimeManager.secondCount + ".";
        }
        if (LapTimeManager.minuteCount <= 9)
        {
            minuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount + ".";
        }
        else
        {
            minuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.minuteCount + ".";
        }

        milliDisplay.GetComponent<Text>().text = "" + LapTimeManager.milliCount;

        LapTimeManager.milliCount = 0;
        LapTimeManager.secondCount = 0;
        LapTimeManager.minuteCount = 0;

        HalfLapTrigg.SetActive(true);
        LapCompleteTrigg.SetActive(false);

    }


}
