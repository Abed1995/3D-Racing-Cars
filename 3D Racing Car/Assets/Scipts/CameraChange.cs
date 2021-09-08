using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject farCamera;
    public GameObject pbCamera;
    int cameraNum;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (cameraNum == 2)
            {
                cameraNum = 0;
            }
            else cameraNum++;

            StartCoroutine(ChangeCam());

        }
    }
    
    IEnumerator ChangeCam()
    {

        yield return new WaitForSeconds(.1f);
        if (cameraNum == 0)
        {
            mainCamera.SetActive(true);
            farCamera.SetActive(false);
            pbCamera.SetActive(false);
        }
        else if (cameraNum == 1 )
        {
            mainCamera.SetActive(false);
            farCamera.SetActive(true);
            pbCamera.SetActive(false);
        }
        else if (cameraNum == 2)
        {
            mainCamera.SetActive(false);
            farCamera.SetActive(false);
            pbCamera.SetActive(true);
        }

    }
         
}
