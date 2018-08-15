using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    public GameObject UI;
    private Vector3 closedPos;
    private Vector3 openPos;
    public GameObject Model;

    private bool MenuOpen;

	// Use this for initialization
	void Start () {
        MenuOpen = false;
        closedPos = new Vector3(0, 0, 0);
        openPos = new Vector3(-300, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void CameraMenu() {
        if (!MenuOpen)
        {
            UI.GetComponent<Animator>().SetBool("IsDisplayed", true);
            MenuOpen = true;
        }
        else
        {
            UI.GetComponent<Animator>().SetBool("IsDisplayed", false);
            MenuOpen = false;
        }
    }
}
