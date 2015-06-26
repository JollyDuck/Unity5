using UnityEngine;
using System.Collections;

public class TrunkGrow : MonoBehaviour {
	public float growRate;
	public GameObject branch;
	public float localTime;
	public float localTime2;
	public float trunkGrowTime;
	public float branchSpawnTime;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
		localTime += Time.deltaTime;
		localTime2 += Time.deltaTime;
		if (localTime2<30){

		//Debug.Log(localTime);
			scale (growRate);
			move (growRate);
			if(localTime>=branchSpawnTime){
				localTime=0; // Reset local time
			// Calculate length of Trunk:
				float treeLength=this.transform.localScale.y;
			// At a scale of 1, length is 1.
			// Spawn Branch in top half of tree, so
			//any transform from scale to scale/2
				float height = (Random.Range(treeLength, treeLength*2)/2);
				int side = (int)Random.Range(0,99);
				spawnBranch(height,side);
			}


		}

	}

	private void spawnBranch(float height, int side){
		Debug.Log ("Running spawnBranch" + height + side);
		float trueSide;
		if (side>49){
			trueSide=-0.4f;
		}
		else trueSide=0.5f;
		GameObject b = (GameObject)Instantiate(branch, new Vector3(trueSide, height,0),Quaternion.identity);
		b.GetComponent<BranchLogic>().growthTime = 30-localTime2;
	}

	private void scale(float rate){
		Vector3 oldScale = transform.localScale;
		//Debug.Log ("old scale: " + oldScale);
		Vector3 add = new Vector3(0f,rate,0f);
		Vector3 newScale = oldScale + add;
		this.gameObject.transform.localScale = newScale;
		//Debug.Log ("new scale: " + newScale);
	}

	public void move(float rate){
		Vector3 oldPos = transform.position;
		oldPos.y += rate/2;
		transform.localPosition = oldPos;
	}
}
