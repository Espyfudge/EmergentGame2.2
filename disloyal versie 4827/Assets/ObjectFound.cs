using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectFound : MonoBehaviour {
    private int objectCounter = 0;


    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void countUp()
    {
        objectCounter =+ 1;
        Debug.Log(objectCounter);
    }
}
