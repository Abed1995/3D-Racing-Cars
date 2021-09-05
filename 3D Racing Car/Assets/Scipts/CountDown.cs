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
    // Start is called before the first frame update
    void Start()
    {
        car.GetComponent<CarController>().enabled = true;
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
        labTimer.SetActive(true);
        car.GetComponent<CarController>().enabled = true;
        

    }
}
