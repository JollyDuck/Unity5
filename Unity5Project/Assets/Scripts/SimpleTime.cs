using UnityEngine;
using System.Collections;

public class SimpleTime : MonoBehaviour {
	public float time;
	public int simpleTime;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		simpleTime = (int)Mathf.FloorToInt(time);
	}
}
