using UnityEngine;
using System.Collections;

public class detectPause : MonoBehaviour 
{
    public GameObject pauseMenu;
    private GameObject player;
    bool paused;

    float time;
	// Use this for initialization
	void Start () 
    {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () 
    {
        checkinputs();
	}

    void checkinputs()
    {
        if (Input.GetKeyDown("escape") && !paused)
        {
            player.GetComponent<AudioSource>().Pause();
            time = Time.timeScale;
            Time.timeScale = 0;
            paused = true;
            pauseMenu.SetActive(true);
        }
        else if (Input.GetKeyDown("escape") && paused)
        {
            player.GetComponent<AudioSource>().UnPause();
            Time.timeScale = time;
            paused = false;
            pauseMenu.SetActive(false);
        }
    }

	public float getTime()
	{
		return(time);
	}
}
