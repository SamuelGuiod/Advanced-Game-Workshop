using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
	public Transform Player;
	public Transform enemy;
	public int speed = 3;
	public bool isAttacking;

	void Awake()
	{

	}

	void Start () {
		isAttacking = false;
	}

	// Update is called once per frame
	void Update () {
		if (isAttacking == true) {
			Player = GameObject.FindGameObjectWithTag ("Player").transform;
			transform.LookAt (Player);
			transform.Translate (Vector3.forward * speed * Time.deltaTime);

		} 

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			isAttacking = true;
		} 


	}


	void OnTriggerExit (Collider other){
		if (other.gameObject.tag == "Player") {
			isAttacking = false;
		}
	}


}
