using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyCarColor : MonoBehaviour
{
    public int matColor;
    // Start is called before the first frame update
    void Start()
    {
        matColor = ChooseCarColor.carcolor;
        switch (matColor)
        {
            case 1:
                this.GetComponent<MeshRenderer>().material.color = Color.red;
                break;

            case 2:
                this.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
            case 3:
                this.GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case 4:
                this.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case 5:
                this.GetComponent<MeshRenderer>().material.color = Color.black;
                break;

        }

      
    }

    
}
