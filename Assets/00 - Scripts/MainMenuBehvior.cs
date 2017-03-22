using UnityEngine;
using System.Collections;

public class MainMenuBehvior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartGame()
    {
        GetComponent<AudioSource>().Play();
    }

    public void QuitGame()
    {

    }

    public void Whatever()
    {

    }
}
