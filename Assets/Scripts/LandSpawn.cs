using UnityEngine;
using System.Collections;

public class LandSpawn : MonoBehaviour {

	public GameObject[] landSpawn;
	public Vector3[] landSpawnPositions;
	public int numberOfLands;
	Vector3 grassToWater, nextLand;
	public string landType;

	// Use this for initialization
	void Start () {
		grassToWater = new Vector3(0f, -0.7f, 0f);
		nextLand = new Vector3(0f,0f,20f);
		if(Application.loadedLevel == 1) {
			LevelOne();
		} else if(Application.loadedLevel == 2) {
			LevelTwo();
		} else if(Application.loadedLevel == 3) {
			LevelThree();
		} else if(Application.loadedLevel == 4) {
			LevelFour();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LevelOne() {
		numberOfLands = 3;
		landSpawn = new GameObject[numberOfLands];
		landSpawnPositions = new Vector3[numberOfLands];
		landSpawnPositions[0] = new Vector3(2.7f, -3.2f, 5.84f);
		landSpawnPositions[1] = landSpawnPositions[0] + grassToWater + nextLand;
		landSpawnPositions[2] = landSpawnPositions[1] + nextLand;
		spawnLand(0, 0);
		spawnLand(1, 1);
		spawnLand(2, 2);
	}

	void LevelTwo() {
		numberOfLands = 6;
		landSpawn = new GameObject[numberOfLands];
		landSpawnPositions = new Vector3[numberOfLands];
		landSpawnPositions[0] = new Vector3(2.7f, -3.2f, 5.84f);
		landSpawnPositions[1] = landSpawnPositions[0] + grassToWater + nextLand;
		landSpawnPositions[2] = landSpawnPositions[1] + nextLand;
		landSpawnPositions[3] = landSpawnPositions[2] + nextLand;
		landSpawnPositions[4] = landSpawnPositions[3] + nextLand;
		landSpawnPositions[5] = landSpawnPositions[4] + nextLand - grassToWater;
		spawnLand(0,0);
		spawnLand(1,1);
		spawnLand(1,2);
		spawnLand(1,3);
		spawnLand(1,4);
		spawnLand(2,5);
	}

	void LevelThree() {
		numberOfLands = 9;
		landSpawn = new GameObject[numberOfLands];
		landSpawnPositions = new Vector3[numberOfLands];
		landSpawnPositions[0] = new Vector3(2.7f, -3.2f, 5.84f);
		landSpawnPositions[1] = landSpawnPositions[0] + grassToWater + nextLand;
		landSpawnPositions[2] = landSpawnPositions[1] + nextLand;
		landSpawnPositions[3] = landSpawnPositions[2] - grassToWater + nextLand;
		landSpawnPositions[4] = landSpawnPositions[3] + grassToWater + nextLand;
		landSpawnPositions[5] = landSpawnPositions[4] + nextLand;
		landSpawnPositions[6] = landSpawnPositions[5] + nextLand;
		landSpawnPositions[7] = landSpawnPositions[6] + nextLand;
		landSpawnPositions[8] = landSpawnPositions[7] + nextLand;
		spawnLand(0,0);
		spawnLand(1,1);
		spawnLand(1,2);
		spawnLand(0,3);
		spawnLand(1,4);
		spawnLand(1,5);
		spawnLand(1,6);
		spawnLand(1,7);
		spawnLand(2,8);
	}

	void LevelFour() {
		numberOfLands = 16;
		landSpawn = new GameObject[numberOfLands];
		landSpawnPositions = new Vector3[numberOfLands];
		landSpawnPositions[0] = new Vector3(2.7f, -3.2f, 5.84f);
		landSpawnPositions[1] = landSpawnPositions[0] + nextLand + grassToWater;
		landSpawnPositions[2] = landSpawnPositions[1] + nextLand - grassToWater;
		landSpawnPositions[3] = landSpawnPositions[2] + nextLand + grassToWater;
		landSpawnPositions[4] = landSpawnPositions[3] + nextLand - grassToWater;
		landSpawnPositions[5] = landSpawnPositions[4] + nextLand + grassToWater;
		landSpawnPositions[6] = landSpawnPositions[5] + nextLand;
		landSpawnPositions[7] = landSpawnPositions[6] + nextLand;
		landSpawnPositions[8] = landSpawnPositions[7] + nextLand;
		landSpawnPositions[9] = landSpawnPositions[8] + nextLand;
		landSpawnPositions[10] = landSpawnPositions[9] + nextLand;
		landSpawnPositions[11] = landSpawnPositions[10] + nextLand;
		landSpawnPositions[12] = landSpawnPositions[11] + nextLand;
		landSpawnPositions[13] = landSpawnPositions[12] + nextLand;
		landSpawnPositions[14] = landSpawnPositions[13] + nextLand;
		landSpawnPositions[14] = landSpawnPositions[13] + nextLand;
		landSpawnPositions[15] = landSpawnPositions[14] + nextLand - grassToWater;
		spawnLand(0,0);
		spawnLand(1,1);
		spawnLand(0,2);
		spawnLand(1,3);
		spawnLand(0,4);
		spawnLand(1,5);
		spawnLand(1,6);
		spawnLand(1,7);
		spawnLand(1,8);
		spawnLand(1,9);
		spawnLand(1,10);
		spawnLand(1,11);
		spawnLand(1,12);
		spawnLand(1,13);
		spawnLand(1,14);
		spawnLand(2,15);
	}
	void spawnLand(int land, int position) {
		switch(land) {
		case 0:
			landType = "Grass";
			break;
		case 1:
			landType = "Water";
			break;
		case 2:
			landType = "Jungle";
			break;
		}

		landSpawn[position] = (GameObject)GameObject.Instantiate(Resources.Load("Prefabs/" + landType));

		if(landType == "Grass") {
			landSpawn[position].transform.position = landSpawnPositions[position];
		} else if(landType == "Water") {
			landSpawn[position].transform.position = landSpawnPositions[position];
		} else if(landType == "Jungle") {
			landSpawn[position].transform.position = landSpawnPositions[position];

		}
	}
}
