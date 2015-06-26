using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//public SpriteRenderer sprRenderer;
	//public Sprite[] sprArray = new Sprite[12];
	float ySpeed=1f;
	float xSpeed=0.1f;
	// Use this for initialization
	void Start () {
	//	sprRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.W)){
			Debug.Log ("W pressed!");
			transform.position.Set(transform.position.x, transform.position.y+ySpeed, transform.position.z);
		}
		/*if(Input.GetAxis("Vertical")<0){
			transform.position.y-=0.1;
		}

		if(Input.GetAxis("Horizontal")>0){
			transform.position.x+=0.1;
		}

		if(Input.GetAxis("Horizontal")<0){
			transform.position.x-=0.1;
		}
		*/
	}
}
