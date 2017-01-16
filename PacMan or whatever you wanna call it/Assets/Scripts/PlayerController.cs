using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public Rigidbody pacman;
	public int score;

    // Use this for initialization
    void Start() {
        pacman = GetComponent<Rigidbody>();
		score = 0;
    }

    // Update is called once per frame
    void FixedUpdate() {
       float moveVertical = Input.GetAxis("Vertical");
       float moveHorizontal = Input.GetAxis("Horizontal");

       Vector3 move = new Vector3(moveHorizontal, 0.0f, moveVertical);

       pacman.AddForce(move * speed);
    }
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Coin")){
			other.gameObject.SetActive(false);
			score++;
		}
	}
}

