using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestLapTime : MonoBehaviour
{
    [SerializeField]
    GameObject bestMilliDisplay;
    [SerializeField]
    GameObject bestSecDisplay;
    [SerializeField]
    GameObject bestMinDisplay;
    [SerializeField]
    GameObject labComplete;
    [SerializeField]
    GameObject HalfLab;
    //[SerializeField]
    //GameObject LabTimeBox;

    public float rawTime;
    private void Start()
    {
        
        
    }
    private void OnTriggerEnter(Collider other)
    {

        rawTime = PlayerPrefs.GetFloat("RawTime");
        if (LapTimeManager.rawTime <= rawTime)
        {
            if (LapTimeManager.secondsTime <= 9)
            {
                bestSecDisplay.GetComponent<Text>().text = "0" + LapTimeManager.secondsTime + ".";
            }
            else
            {
                bestSecDisplay.GetComponent<Text>().text = "" + LapTimeManager.secondsTime + ".";
            }
            if (LapTimeManager.MinutesTime <= 9)
            {
                bestMinDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinutesTime + ":";
            }
            else
            {
                bestMinDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinutesTime + ":";
            }

            bestMilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.millitime;
        }


        PlayerPrefs.SetInt("MaxMin", LapTimeManager.MinutesTime);
        PlayerPrefs.SetInt("MaxSec", LapTimeManager.secondsTime);
        PlayerPrefs.SetFloat("MaxMilli", LapTimeManager.millitime);
        PlayerPrefs.SetFloat("RawTime", LapTimeManager.rawTime);

        LapTimeManager.secondsTime = 0;
        LapTimeManager.MinutesTime = 0;
        LapTimeManager.millitime = 0;
        LapTimeManager.rawTime = 0;

        HalfLab.SetActive(true);
        labComplete.SetActive(false);

    }
}
