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
