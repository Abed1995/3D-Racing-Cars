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

    public
    float sec;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
        minCount = PlayerPrefs.GetInt("MaxMin");


        secCount = PlayerPrefs.GetInt("MaxSec");


        milliCount = PlayerPrefs.GetFloat("MaxMilli");
       

        sec = secCount;

        if (secCount<= 9)
        {
            bestSecDisplay.GetComponent<Text>().text = "0" + secCount + ".";
        }
        else 
        {
            bestSecDisplay.GetComponent<Text>().text = "" + secCount + ".";
        }
        if (minCount<= 9)
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
