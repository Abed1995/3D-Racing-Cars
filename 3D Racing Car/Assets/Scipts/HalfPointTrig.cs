using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrig : MonoBehaviour
{
    [SerializeField]
    GameObject endPoint;
    [SerializeField]
    GameObject halfWayPoint;


    private void OnTriggerEnter(Collider other)
    {
        endPoint.SetActive(true);
        halfWayPoint.SetActive(false);


    }


}
