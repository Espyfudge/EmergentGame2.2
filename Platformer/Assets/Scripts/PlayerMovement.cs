using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public KeyCode moveLeft;
	public KeyCode moveRight;
	public KeyCode jump;
	private Rigidbody2D rb;
	public float speed = 5f;
	private float originalSpeed;
	public float jumpHeight = 5f;
	public float balloon = 3f;
	private bool onGround;
	private bool canMove = true;
	private ChangeHead ch;
	public GameObject gameOver;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		ch = GetComponent<ChangeHead>();
		originalSpeed = speed;
	}
	
	// Update is called once per frame
	void Update () {
		if (canMove) {
			if (rb.velocity.y == 0f) {
				onGround = true;
			}

			if (ch.head != 4) {
				speed = originalSpeed;
				rb.gravityScale = 1.3f;
				if (Input.GetKeyDown(jump) && (onGround)) {
					if (ch.head != 3 ) {
						rb.velocity = new Vector2(rb.velocity.x,jumpHeight);
					}
					else {
						rb.velocity = new Vector2(rb.velocity.x,jumpHeight * 1.25f);
					}
					onGround = false;
				}
			}

			if (ch.head == 4) {
				rb.gravityScale = -1f;
				speed = 1f;
				rb.velocity = new Vector2(rb.velocity.x, balloon);
			}

			if (Input.GetKey(moveLeft))	{
				rb.velocity = new Vector2(-speed,rb.velocity.y);
			}
			else if (Input.GetKey(moveRight))	{
				rb.velocity = new Vector2(speed,rb.velocity.y);
			}
			else {
				rb.velocity = new Vector2(0f, rb.velocity.y);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if ( other.gameObject.tag == "Spikes" ) {
			if (ch.head != 2) {
				gameOver.SetActive(true);
				canMove = false;
				rb.velocity = new Vector2(0f,0f);
			}
		}
	}
}
