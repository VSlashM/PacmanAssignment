using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostController : MonoBehaviour {
	public Rigidbody ghost;
	public NavMeshAgent nav;
	Transform player;

	void Awake(){
		ghost = GetComponent<Rigidbody> ();
		nav = GetComponent<NavMeshAgent> ();
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination(player.position);
	}
}
