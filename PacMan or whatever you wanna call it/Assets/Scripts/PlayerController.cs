using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public Rigidbody pacman;
	public Screen screen;
	public int score;
	public int lives;
	public Text scoreDisplay;
	public Text livesDisplay;
	public Vector3 startingPosition;
	public Vector3 topLeftTeleport;
	public Vector3 topRightTeleport;
	public Vector3 bottomLeftTeleport;
	public Vector3 bottomRightTeleport;

	// Use this for initialization
	void Start ()
	{
		
		pacman = GetComponent<Rigidbody> ();
		startingPosition = pacman.transform.position; 
		topLeftTeleport = new Vector3 (-10f, 0.75f, 14f);
		topRightTeleport = new Vector3 (10f, 0.75f, 14f);
		bottomLeftTeleport = new Vector3 (-10f, 0.75f, -14f);
		bottomRightTeleport = new Vector3 (10f, 0.75f, -14f);
		scoreDisplay.text = "Score: " + score;
		livesDisplay.text = "Lives: " + lives;

	}

	void FixedUpdate ()
	{
		float moveVertical = Input.GetAxis ("Vertical");
		float moveHorizontal = Input.GetAxis ("Horizontal");
		if (pacman.transform.position.x > 9f && pacman.transform.position.z > 14.9) {
			pacman.MovePosition (bottomRightTeleport);
		} else if (pacman.transform.position.x < -9f && pacman.transform.position.z > 14.9) {
			pacman.MovePosition (bottomLeftTeleport);
		} else if (pacman.transform.position.x > 9f && pacman.transform.position.z < -14.9) {
			pacman.MovePosition (topRightTeleport);
		} else if (pacman.transform.position.x < -9f && pacman.transform.position.z < -14.9) {
			pacman.MovePosition (topLeftTeleport);
		}
		Vector3 move = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		pacman.AddForce (move * speed);
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Coin")) {
			other.gameObject.SetActive (false);
			score++;
			scoreDisplay.text = "Score: " + score;
		} else if (other.gameObject.CompareTag ("Ghost")) {
			pacman.MovePosition (startingPosition);
			lives--;
			livesDisplay.text = "Lives: " + lives;

		}
	}
}

