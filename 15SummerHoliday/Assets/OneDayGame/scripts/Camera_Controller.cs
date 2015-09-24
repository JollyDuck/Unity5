using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Camera_Controller : MonoBehaviour {

    // Use this for initialization
    Transform playerTransform;
    List<Vector3> list;
    Vector3 startingDifference;
    public GameObject t;
	void Start () {
        playerTransform = t.transform;
        list = new List<Vector3>(25);
        startingDifference = transform.position - playerTransform.position;
       // Debug.Log("Starting Difference:" + startingDifference);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate ()
    {
        list.Add(playerTransform.position);
       

    
    }

    void LateUpdate()
    {
 
        if (list.Count > 20)
        {
           // Debug.Log("List is > 118");
            float newX = list[0].x + startingDifference.x;
            float newY = list[0].y + startingDifference.y;
            float newZ = list[0].z + startingDifference.z;
           // Debug.Log("Setting new position: " + newX + newY + newY);
            //transform.localPosition.Set(newX, newY, newZ);
            transform.position = new Vector3(newX, 0f, newZ);
            list.RemoveAt(0);
        }
        

    }
}
