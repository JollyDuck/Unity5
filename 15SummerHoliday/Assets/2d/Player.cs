using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//public SpriteRenderer sprRenderer;
	//public Sprite[] sprArray = new Sprite[12];
	public float ySpeed=100f;
	public float xSpeed=100f;
	private Rigidbody2D rb2;
	// Use this for initialization
	void Start () {
	//	sprRenderer = GetComponent<SpriteRenderer>();
		rb2 = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		//Input.GetAxis("Vertical")
		if(Input.GetAxis("Vertical")!=0){
			//Debug.Log ("W pressed!");
			rb2.AddForce(Vector2.up*ySpeed*Input.GetAxis("Vertical"));
		}


		if(Input.GetAxis("Horizontal")!=0){
			rb2.AddForce(Vector2.right*ySpeed*Input.GetAxis("Horizontal"));
		}

	}
}
