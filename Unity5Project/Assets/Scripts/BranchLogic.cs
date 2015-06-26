using UnityEngine;
using System.Collections;

public class BranchLogic : MonoBehaviour {
	private float localTime;
	public float rate;
	private bool left = false;
	public float growthTime;
	public int numSmallBranchSeeds;
	public int numLeaves;
	// Use this for initialization
	void Start () {
		if(transform.position.x<0){
			left=true;
		}
		transform.Rotate(0,0,Random.Range(-3,20));
	}
	
	// Update is called once per frame
	void Update () {
		localTime += Time.deltaTime;
		if(localTime<=growthTime){
			if (left){
				scaleL (rate);
				moveL (rate);
			}
			else{
				scaleR (rate);
				moveR (rate);
			}
		}
	}

	private void scaleR(float rate){
		Vector3 oldScale = transform.localScale;
		//Debug.Log ("old scale: " + oldScale);

		Vector3 add = new Vector3(rate,0f,0f);
		Vector3 newScale = oldScale + add;
		this.gameObject.transform.localScale = newScale;
		//Debug.Log ("new scale: " + newScale);
	}
	
	public void moveR(float rate){
		Vector3 oldPos = transform.position;
		float y = Mathf.Sin(transform.localRotation.z)*rate;
		oldPos.x += rate/2;
		oldPos.y += y;
		transform.localPosition = oldPos;
	}
	
	private void scaleL(float rate){
		Vector3 oldScale = transform.localScale;
		//Debug.Log ("old scale: " + oldScale);
		Vector3 add = new Vector3(-rate,0f,0f);
		Vector3 newScale = oldScale + add;
		this.gameObject.transform.localScale = newScale;
		//Debug.Log ("new scale: " + newScale);
	}

	public void moveL(float rate){
		Vector3 oldPos = transform.position;
		oldPos.x -= rate/2;
		float y = Mathf.Sin(transform.localRotation.z)*rate;
		oldPos.y -= y;
		transform.localPosition = oldPos;
	}
}
