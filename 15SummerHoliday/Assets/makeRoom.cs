using UnityEngine;
using System.Collections;

public class makeRoom : MonoBehaviour {
	public GameObject[] prefabs = new GameObject[7];
	public int widthOfTiles = 2;
	//0-2 are floor
	//3-4 are fancy floor
	//5-6 are walls
	// Use this for initialization
	void Start () {
		genRoom(22,20);
	}

	void genRoom(int width, int height){
		int placeX = (int)transform.position.x - width/2;
		int placeY = (int)transform.position.y - height/2;
		for(int x=placeX; x<(placeX + width); x+=widthOfTiles){
			for(int y=placeY; y<(placeY + height); y+=widthOfTiles){
				int floor = 0;

				//Wall tile
				if(x==placeX || y == placeY || x == placeX+width-(1*widthOfTiles)
				   || y == placeY+height-(1*widthOfTiles))
				   {
					floor = 5;// (int)Random.Range(5,7); // tiles 0-2 due to rounding
				} //Floor Tile
				else{
					floor = (int)Random.Range(0,3); // tiles 0-2 due to rounding
				}
				Debug.Log(floor);
				Instantiate(prefabs[floor], new Vector3(x, y, 0), Quaternion.identity);
			}
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
