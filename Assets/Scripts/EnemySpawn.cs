using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	string enemyType;
	public GameObject[] enemySpawn;
	public Vector3[] enemySpawnPositions;
	public int numberOfEnemies;
	// Use this for initialization
	void Start () {
		if(Application.loadedLevel == 1) {
			LevelOne();
		} else if(Application.loadedLevel == 2) {
			LevelTwo();
		} else if(Application.loadedLevel == 3) {
			LevelThree();
		}
	}
	
	// Update is called once per frame
	void Update () {
		enemyOverFlow();

	}
	
	void LevelOne() {
		numberOfEnemies = 2;
		enemySpawnPositions = new Vector3[numberOfEnemies];
		enemySpawn = new GameObject[numberOfEnemies];
		enemySpawnPositions[0] = GameObject.FindGameObjectsWithTag("Water")[0].transform.position + new Vector3(72.3f, 2f, -5.0f);
		enemySpawnPositions[1] = enemySpawnPositions[0] + new Vector3(-10f, 0f, 10f);
		spawnRandomEnemy(0, 1, 1);
		spawnRandomEnemy(1, 0, 1);
	}

	void LevelTwo() {
		numberOfEnemies = 5;
		enemySpawnPositions = new Vector3[numberOfEnemies];
		enemySpawn = new GameObject[numberOfEnemies];
		enemySpawnPositions[0] = GameObject.FindGameObjectsWithTag("Water")[0].transform.position + new Vector3(73f, 0f, -5.0f);
		enemySpawnPositions[1] = enemySpawnPositions[0] + new Vector3(-146f, 0f, 10f);
		enemySpawnPositions[2] = enemySpawnPositions[1] + new Vector3(146f, 0f, 20f);
		enemySpawnPositions[3] = enemySpawnPositions[2] + new Vector3(-146f, 0f, 10f);
		enemySpawnPositions[4] = enemySpawnPositions[3] + new Vector3(146f, 0f, 20f);
		spawnRandomEnemy(1, 0, 1);
		spawnRandomEnemy(0, 1, -1);
		spawnRandomEnemy(0, 2, 1);
		spawnRandomEnemy(1, 3, -1);
		spawnRandomEnemy(1, 4, 1);
	}

	void LevelThree() {
		numberOfEnemies = 9;
		enemySpawnPositions = new Vector3[numberOfEnemies];
		enemySpawn = new GameObject[numberOfEnemies];
		enemySpawnPositions[0] = GameObject.FindGameObjectsWithTag("Water")[0].transform.position + new Vector3(73f, 0f, -5.0f) + new Vector3(0f, 0f, 10f);
		enemySpawnPositions[1] = enemySpawnPositions[0] + new Vector3(-10f, 0f, 10f);
		enemySpawnPositions[2] = enemySpawnPositions[1] + new Vector3(10f, 0f, 10f);
		enemySpawnPositions[3] = enemySpawnPositions[2] + new Vector3(-146f, 0f, 40f);
		enemySpawnPositions[4] = enemySpawnPositions[3] + new Vector3(10f, 0f, 10f);
		enemySpawnPositions[5] = enemySpawnPositions[4] + new Vector3(-20f, 0f, 10f);
		enemySpawnPositions[6] = enemySpawnPositions[5] + new Vector3(-30f, 0f, 10f);
		enemySpawnPositions[7] = enemySpawnPositions[6] + new Vector3(40f, 0f, 10f);
		enemySpawnPositions[8] = enemySpawnPositions[7] + new Vector3(10f, 0f, 10f);
		spawnRandomEnemy(0, 0, 1);
		spawnRandomEnemy(0, 1, 1);
		spawnRandomEnemy(0, 2, 1);
		spawnRandomEnemy(1, 3, -1);
		spawnRandomEnemy(1, 4, -1);
		spawnRandomEnemy(1, 5, -1);
		spawnRandomEnemy(1, 6, -1);
		spawnRandomEnemy(1, 7, -1);
		spawnRandomEnemy(1, 8, -1);
	}

	void enemyOverFlow() {
		for(int i = 0; i < enemySpawn.Length; i++) {
			if(enemySpawn[i].transform.position.x <= -125f || enemySpawn[i].transform.position.x >= 125) {
				if(enemySpawn[i].tag == "Snake") {
				enemySpawn[i].transform.position = enemySpawnPositions[i] + new Vector3(0f, 2f, 0f);
				} else if(enemySpawn[i].tag == "Shark") {
					enemySpawn[i].transform.position = enemySpawnPositions[i];
				}
			}
		}
	}

	void spawnRandomEnemy(int enType, int enemyPosition, int inverse) {
		switch(enType) {
		case 0: 
			enemyType = "Shark";
			Debug.Log("Shark");
			break;
		case 1: 
			enemyType = "Snake";
			Debug.Log ("Snake");
			break;
		}

		enemySpawn[enemyPosition] = (GameObject)GameObject.Instantiate(Resources.Load("Prefabs/" + enemyType));

		if(inverse == -1) {
			enemySpawn[enemyPosition].transform.eulerAngles += new Vector3(0f, 180f, 0f);
		}
		
		if(enemyType == "Snake") {
			enemySpawn[enemyPosition].transform.position = enemySpawnPositions[enemyPosition] + new Vector3(0f, 2f, 0f);
			enemySpawn[enemyPosition].GetComponent<Rigidbody>().AddForce(-85f * inverse,0f, 0f, ForceMode.VelocityChange);
		} else if(enemyType == "Shark") {
			enemySpawn[enemyPosition].transform.position = enemySpawnPositions[enemyPosition];
			enemySpawn[enemyPosition].GetComponent<Rigidbody>().AddForce(-55f * inverse,0f, 0f, ForceMode.VelocityChange);
		}


		
	}
}
