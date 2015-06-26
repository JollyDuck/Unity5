using UnityEngine;
using System.Collections;

public class CamControl : MonoBehaviour {
	public float speed;
	public float localTime;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		localTime += Time.deltaTime;
		if (localTime<=30){
			Camera.main.orthographicSize += speed;
		}
	}
}
