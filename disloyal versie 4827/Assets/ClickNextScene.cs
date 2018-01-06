using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickNextScene : MonoBehaviour {
    public GameObject hiddenObjGame;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hiddenObjGame.SetActive(true);
            gameObject.SetActive(false);
        }
    }


}
