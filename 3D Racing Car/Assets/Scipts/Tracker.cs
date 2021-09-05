using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    [SerializeField]
    GameObject[] mark;
    [SerializeField]
    GameObject tracker;
    
    // Start is called before the first frame update
    
    int marksGained;
    // Update is called once per frame
    void Update()
    {
        if (marksGained == 25)
        {
            marksGained = 0;
        }
        tracker.transform.position = mark[marksGained].transform.position;
      
        //switch (marksGained)
        //{
        //    case 0:
        //        tracker.transform.position = mark[1].transform.position;
        //        break;
        //    case 1:
        //        tracker.transform.position = mark[2].transform.position;
        //        break;
        //    case 2:
        //        tracker.transform.position = mark[3].transform.position;
        //        break;
        //    case 3:
        //        tracker.transform.position = mark[4].transform.position;
        //        break;
        //    case 4:
        //        tracker.transform.position = mark[5].transform.position;
        //        break;
        //    case 5:
        //        tracker.transform.position = mark[6].transform.position;
        //        break;
        //    case 6:
        //        tracker.transform.position = mark[7].transform.position;
        //        break;
        //    case 7:
        //        tracker.transform.position = mark[8].transform.position;
        //        break;
        //    case 8:
        //        tracker.transform.position = mark[9].transform.position;
        //        break;
        //    case 9:
        //        tracker.transform.position = mark[10].transform.position;
        //        break;
        //    case 10:
        //        tracker.transform.position = mark[11].transform.position;
        //        break;
        //    case 11:
        //        tracker.transform.position = mark[12].transform.position;
        //        break;
        //    case 12:
        //        tracker.transform.position = mark[13].transform.position;
        //        break;
        //    case 13:
        //        marksGained = 0;
        //        break;
        //    default:
        //        break;
        //}
        Debug.Log(marksGained);
    }
    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Opponent")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            marksGained++;

        }
        yield return new WaitForSeconds(1);
        this.GetComponent<BoxCollider>().enabled = true;

    }
}
