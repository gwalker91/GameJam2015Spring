using UnityEngine;
using System.Collections;

public class triggerHallway : MonoBehaviour {

    GameObject manager;

	// Use this for initialization
	void Start () 
    {
        manager = GameObject.Find("MainCylinder");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider x)
    {
        if(x.tag == "Player")
        {
            manager.GetComponent<circleTrap>().changeHallway();

        }
    }
}
