using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float speed;
    public Rigidbody pacman;
	public int score;
	public Text scoreDisplay;

    // Use this for initialization
    void Start() {
        pacman = GetComponent<Rigidbody>();
		score = 0;
		scoreDisplay.text = "Score: " + score;
    }

    void FixedUpdate() {
       float moveVertical = Input.GetAxis("Vertical");
       float moveHorizontal = Input.GetAxis("Horizontal");

       Vector3 move = new Vector3(moveHorizontal, 0.0f, moveVertical);
		Vector3 teleport = new Vector3 (23f, 0.75f, 23f);
		Vector3 reset = new Vector3 (-24.0f, 0.75f, -24.0f);
		if (pacman.transform.position.x <= 25f && pacman.transform.position.x >= 24f &&  pacman.transform.position.z <= 25f && pacman.transform.position.z >= 24f) {
			pacman.MovePosition(reset);
		}
       pacman.AddForce(move * speed);
    }

	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Coin")){
			other.gameObject.SetActive(false);
			score++;
			scoreDisplay.text = "Score: " + score;
		}
	}
}

