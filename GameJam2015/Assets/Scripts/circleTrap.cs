using UnityEngine;
using System.Collections;

public class circleTrap : MonoBehaviour 
{
    public GameObject[] outerWalls = new GameObject[21];
    public GameObject[] innerWalls = new GameObject[21];

    int number = 0;
    public int counter = 0;

	// Use this for initialization
	void Start () 
    {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}

    public void changeHallway()
    {
        outerWalls[number].SetActive(true);
        innerWalls[number].SetActive(true);
        number = Random.Range(0, 21);
        outerWalls[number].SetActive(false);
        innerWalls[number].SetActive(false);
    }
}
