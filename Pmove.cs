using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pmove : MonoBehaviour {



	private float Jumpstart = 1f;
	public float Jumpcooldown = 0f;
	public IEnumerator Coroutine;
	public float jumpForce = 10;
	public float speed = 6f;
	public float gravity = 20.0F;

	// Use this for initialization
	void Start () {
		Jumpcooldown = 0;
	}

	// Update is called once per frame
	void Update () {

		if (Jumpcooldown > 0) {
			Jumpcooldown -= Time.deltaTime;
		}
		if (Jumpcooldown < 0) {
			Jumpcooldown = 0;
		}

		if (Input.GetButtonDown ("Vertical") && Jumpcooldown == 0) {
			Jumpcooldown = Jumpstart;
			StartCoroutine (Jump ());


		}




		float h = Input.GetAxisRaw ("Horizontal");
		//float v = Input.GetAxisRaw ("Vertical");
		transform.position += new Vector3 (h, 0) * Time.deltaTime * speed * gravity * 1 / Time.timeScale;

	}

	IEnumerator Jump(){
		GetComponent<Rigidbody>().AddForce(new Vector2(0, jumpForce), ForceMode.Impulse);
		yield return new WaitForSeconds (0f);
		
}
}
