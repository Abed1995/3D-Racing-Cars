using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour
{

    [SerializeField]
    GameObject TheCar;

    float carX, carY, carZ;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        carX = TheCar.transform.eulerAngles.x;
        carY = TheCar.transform.eulerAngles.y;
        carZ = TheCar.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(0, carY, 0);
    }
}
