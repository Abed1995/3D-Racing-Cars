using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
     public static int secondsTime, MinutesTime;
    public static float millitime;
    [SerializeField]
    GameObject milleSecondsDisplay;
    [SerializeField]
    GameObject secondsDisplay;
    [SerializeField]
    GameObject minutesDisplay;


    public static float rawTime;
    // Update is called once per frame
    void Update()
    {
        millitime += Time.deltaTime*10;
        rawTime += Time.deltaTime;
        milleSecondsDisplay.GetComponent<Text>().text = "" + millitime;
        if(millitime >= 10)
        {
            secondsTime ++;
            millitime = 0;
        }
        if (secondsTime<10)
        {
            secondsDisplay.GetComponent<Text>().text = "0" + secondsTime +":";
        }
        else if (secondsTime >= 10)
        {
            secondsDisplay.GetComponent<Text>().text = "" + secondsTime + ":";
        }

        if (secondsTime>=60)
        {
            MinutesTime++;
            secondsTime = 0;
        }
        if (MinutesTime <=9)
        {
            minutesDisplay.GetComponent<Text>().text = "0" + MinutesTime + ":";
        }
        else
        {
            minutesDisplay.GetComponent<Text>().text = "" + MinutesTime + ":";
        }

    }
}
