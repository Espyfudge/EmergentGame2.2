using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour {
    public GameObject hiddenObjGame;
    public GameObject evidence;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoBack()
    {
        hiddenObjGame.SetActive(false);
        evidence.SetActive(false);
    }
}
