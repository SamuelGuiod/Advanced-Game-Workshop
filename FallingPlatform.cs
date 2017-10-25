using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour {

	public float timeInSeconds;
	public float respawnTime;
	private Vector3 StartingPos;

	// Use this for initialization
	void Start () {
		StartingPos = gameObject.transform.position;
		//Debug.Log ("Debug working");
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter (Collision other){
		//Debug.Log ("Collision is read");
		if (other.gameObject.tag == "Player") {
			//Debug.Log ("Tag is Player");
			StartCoroutine (Fall ());
		}
	}
	private IEnumerator Fall(){
		//Debug.Log ("Fall should happen");
		yield return new WaitForSeconds (timeInSeconds);
		gameObject.GetComponent<Rigidbody> ().isKinematic = false;
		gameObject.GetComponent<Rigidbody> ().useGravity = true;
		yield return new WaitForSeconds (respawnTime);
		gameObject.GetComponent<Rigidbody> ().isKinematic = true;
		gameObject.GetComponent<Rigidbody> ().useGravity = false;
		gameObject.transform.SetPositionAndRotation(StartingPos, new Quaternion(0,0,0,0));
	}
}
