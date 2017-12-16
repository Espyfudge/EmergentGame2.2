using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	private Image imFill;
	private float acFill = 1;
    public Text timeUpText;
	// Use this for initialization
	void Start () {
		imFill = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		acFill -= Time.deltaTime / 10;
		
		imFill.fillAmount = acFill;

		if ( imFill.fillAmount <= 0.0f ) {
            timeUpText.text = "Your time is up!";

			// what happens when time is up

		}
	}
}
