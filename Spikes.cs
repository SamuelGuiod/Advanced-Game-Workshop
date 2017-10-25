  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

	public float Damage = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/*
	void OnColliderEnter(Collider other){
		if (other.tag == "Player") {
			other.GetComponent<PlayerController> ().Damage(Damage);
		}
	}
	*/
}
