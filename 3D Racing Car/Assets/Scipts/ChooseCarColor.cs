using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCarColor : MonoBehaviour
{
    public static int carcolor;

    public GameObject selectTrackPanel;
    public void redButton()
    {
        carcolor = 1;
        selectTrackPanel.SetActive(true);
    }
   
    public void yellowButton()
    {
        carcolor = 2;
        selectTrackPanel.SetActive(true);
    }
    public void BlueButton()
    {
        carcolor = 3;
        selectTrackPanel.SetActive(true);
    }
    public void GreenButton()
    {
        carcolor = 4;
        selectTrackPanel.SetActive(true);
    }
    public void BlackButton()
    {
        carcolor = 5;
        selectTrackPanel.SetActive(true);
    }

}
