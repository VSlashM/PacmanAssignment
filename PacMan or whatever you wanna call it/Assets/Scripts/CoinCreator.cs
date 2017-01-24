using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCreator : MonoBehaviour {
	public Rigidbody coin;
	public int coinAmount;
	void Start () {
		//Vector3 rotation = new Vector3 (90.0f, 90.0f, 45.0f);
		for (int i = 0; i <= coinAmount; i++) {
			Vector3 pos = new Vector3 (Random.Range (-7f, 7f), 0.6f, Random.Range (-14f, 14f));
			Rigidbody coinClone = (Rigidbody)Instantiate (coin, pos, transform.rotation);
		}
	}	

	void Update () {
		
	}
}
