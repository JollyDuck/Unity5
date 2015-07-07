using UnityEngine;
using System.Collections;

public class levelGenerator : MonoBehaviour {
	public GameObject[] prefabs = new GameObject[8];
	public int widthOfTiles = 2;
	public int mapSizeX = 50;
	public int mapSizeY = 50;
	//0-2 are floor
	//3-4 are fancy floor
	//5-6 are walls
	//7 is !!!!!player!!!!!
	//20 is blank
	// Use this for initialization
	void Start () {
		int[,] array = new int[mapSizeX,mapSizeY];
		for(int a = 0; a<mapSizeX; a++){
			for(int b = 0; b<mapSizeY; b++){
				array[a,b] = 20;
				Debug.Log ("Assigned 20 to room");
			}

		}

		//genRoom(22,20);
	}

	/*
	 * 1. Make an array of tiles filled with 'blank'
	 * 2. Make a base room at 1,1 of size 10x10
	 * 3. From an edge, take a 5-15 step walk in a random direction, then make another room
	 * 4. Make X? amount of rooms
	 * Rooms are defined by their bottom left corner and their width and height,
	 * so 20,20,10,10 is a 10x10 room with bottom left starting at 20,20)
	 * 
	 * 
	 * */

	/*void genRoom(int width, int height){
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
	*/
	// Update is called once per frame
	void Update () {
	
	}
}
