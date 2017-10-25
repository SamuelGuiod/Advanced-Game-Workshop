using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phealth : MonoBehaviour {
	public float lives = 2;
	private float heal;

	void Start () {
		heal = lives;
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision coll) {
		if (coll.gameObject.tag == "Enemy"){
			heal -= 1;
			if (heal <= 0) {

				Destroy (this.gameObject);
			}
		}	
		
	}
}
