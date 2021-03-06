using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CountDown : MonoBehaviour
{
    public GameObject countdown;
    public AudioSource getready;
    public AudioSource go;
    public GameObject labTimer;
    public GameObject car;
    public GameObject opponentCar;
    // Start is called before the first frame update
    void Start()
    {
        labTimer.GetComponent<LapTimeManager>().enabled = false;
        car.GetComponent<CarUserControl>().enabled = false;
        opponentCar.GetComponent<CarAIControl>().enabled = false;
        StartCoroutine(countDown());
    }

    IEnumerator countDown()
    {
        yield return new WaitForSeconds(.5f);
        countdown.GetComponent<Text>().text = "3";
        getready.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        countdown.GetComponent<Text>().text = "2";
        getready.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        countdown.GetComponent<Text>().text = "1";
        go.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        labTimer.GetComponent<LapTimeManager>().enabled = true;
        car.GetComponent<CarUserControl>().enabled = true;
        opponentCar.GetComponent<CarAIControl>().enabled = true;


    }
}
