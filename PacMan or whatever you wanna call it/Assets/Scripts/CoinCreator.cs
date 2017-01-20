using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCreator : MonoBehaviour {
	public Rigidbody coin;

	void Start () {
		
		//Vector3 rotation = new Vector3 (90.0f, 90.0f, 45.0f);
		for (int i = 0; i < 20; i++) {
			Vector3 pos = new Vector3 (Random.Range (-24f, 24f), 0.6f, Random.Range (-24f, 24f));
			Rigidbody coinClone = (Rigidbody)Instantiate (coin, pos, transform.rotation);
		}
	}	

	void Update () {
		
	}
}
