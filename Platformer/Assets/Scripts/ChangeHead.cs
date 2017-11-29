using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHead : MonoBehaviour {

	public Sprite sprite1;
	public Sprite sprite2;
	public Sprite sprite3;
	public Sprite sprite4;
	private SpriteRenderer spr;
	public int head = 1;
	// Use this for initialization
	void Start () {
		spr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			head = 1;
			spr.sprite = sprite1;
		}

		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			head = 2;
			spr.sprite = sprite2;
		}

		if (Input.GetKeyDown(KeyCode.Alpha3)) {
			head = 3;
			spr.sprite = sprite3;
		}

		if (Input.GetKeyDown(KeyCode.Alpha4)) {
			head = 4;
			spr.sprite = sprite4;
		}
	}
}
