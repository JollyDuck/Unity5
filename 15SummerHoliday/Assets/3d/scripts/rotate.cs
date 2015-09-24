using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		//	sprRenderer = GetComponent<SpriteRenderer>();
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void FixedUpdate() {
		if(Input.GetAxis("Horizontal")!=0){
			rb.AddTorque(0, 0, Input.GetAxis("Horizontal"));
			//Debug.Log("Applying Torque of " + Input.GetAxis("Horizontal"));
		}
	}
}
