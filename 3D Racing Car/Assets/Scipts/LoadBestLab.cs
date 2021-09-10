using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadBestLab : MonoBehaviour
{
    [SerializeField]
    GameObject bestMilliDisplay;
    [SerializeField]
    GameObject bestSecDisplay;
    [SerializeField]
    GameObject bestMinDisplay;

    [SerializeField]
    float minCount;
    float secCount;
    float milliCount;
    // Start is called before the first frame update
    void Start()
    {

        minCount = PlayerPrefs.GetFloat("MaxMin");


        secCount = PlayerPrefs.GetFloat("MaxSec");


        milliCount = PlayerPrefs.GetFloat("MaxMilli");
       

        Debug.Log(PlayerPrefs.GetString("Abed"));

        if (LapTimeManager.secondsTime <= 9)
        {
            bestSecDisplay.GetComponent<Text>().text = "0" + secCount + ".";
        }
        else
        {
            bestSecDisplay.GetComponent<Text>().text = "" + secCount + ".";
        }
        if (LapTimeManager.MinutesTime <= 9)
        {
            bestMinDisplay.GetComponent<Text>().text = "0" + minCount + ":";
        }
        else
        {
            bestMinDisplay.GetComponent<Text>().text = "" + minCount + ":";
        }

        bestMilliDisplay.GetComponent<Text>().text = "" +  milliCount ;
    }



}
