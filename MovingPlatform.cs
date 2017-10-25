using System.Collections;
using System.Collections.Generic;
using UnityEngine;
				//  WARNING: BROKEN AS HELL  //
public class MovingPlatform : MonoBehaviour {

	private float originalHeight;
	private float originalWidth;
	public float height = 10.0f;
	public float width = 0.0f;
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		originalHeight = height;
		originalWidth = width;
		StartCoroutine(Movement());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private IEnumerator Movement(){
		while (true) {
			if (height > 0) {
				height = height + speed;
				GetComponent<Rigidbody> ().MovePosition (transform.position + new Vector3 (speed, 0.0f, 0.0f));
				if (height < 0)
					height = 0.0f;
			}
			if (height == 0 && originalHeight != 0) {
				originalHeight = -originalHeight;
				height = originalHeight;
				yield return new WaitForSeconds (3);
			}
			if (height < 0) {
				height = height - speed;
				GetComponent<Rigidbody> ().MovePosition (transform.position - new Vector3 (speed, 0.0f, 0.0f));
				if (height > 0)
					height = 0.0f;
			}
			if (width > 0) {
				width = width + speed;
				GetComponent<Rigidbody> ().MovePosition (transform.position + new Vector3 (0.0f, speed, 0.0f));
				if (width < 0)
					width = 0.0f;
			}
			if (width == 0 && originalWidth != 0) {
				originalWidth = -originalWidth;
				width = originalWidth;
				yield return new WaitForSeconds (3);
			}
			if (width < 0) {
				width = width - speed;
				GetComponent<Rigidbody> ().MovePosition (transform.position - new Vector3 (0.0f, speed, 0.0f));
				if (width > 0)
					width = 0.0f;
			}
		}
	}
}