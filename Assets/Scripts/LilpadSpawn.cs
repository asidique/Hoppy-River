using UnityEngine;
using System.Collections;

public class LilpadSpawn : MonoBehaviour {
	GameObject[] Lilypad;
	Vector3[] Lilypadpositions;
	int numberOfLilypads;
	Vector3 Vertical;
	Vector3 Horizontal;

	void Start () {
		Vertical = new Vector3(0f, 0f, 10f);
		Horizontal = new Vector3(10f, 0f, 0f);
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

	void spawnLilyPad(int type, int position) {
		//switch(type) {
			//add different floatable objects here
		//}

		Lilypad[position] = (GameObject)GameObject.Instantiate(Resources.Load("Prefabs/Lilypad"));
		Lilypad[position].transform.position = Lilypadpositions[position];
	}

	void LevelOne() {
		numberOfLilypads = 2;
		Lilypad = new GameObject[numberOfLilypads];
		Lilypadpositions = new Vector3[GameObject.FindGameObjectsWithTag("Water").Length * 2];
		Lilypadpositions[0] = GameObject.FindGameObjectsWithTag("Water")[0].transform.position + new Vector3(-3.2f, 1.2f, -5.0f);
		Lilypadpositions[1] = Lilypadpositions[0] + Vertical;
		spawnLilyPad(0, 0);
		spawnLilyPad(0, 1);
	}

	void LevelTwo() {
		numberOfLilypads = 10;
		Lilypad = new GameObject[numberOfLilypads];
		Lilypadpositions = new Vector3[numberOfLilypads];
		Lilypadpositions[0] = GameObject.FindGameObjectsWithTag("Water")[0].transform.position + new Vector3(-3.2f, 1.2f, -5.0f);
		Lilypadpositions[1] = Lilypadpositions[0] + Vertical;
		Lilypadpositions[2] = Lilypadpositions[1] + Vertical;
		Lilypadpositions[3] = Lilypadpositions[2] + Horizontal;
		Lilypadpositions[4] = Lilypadpositions[3] + Vertical;
		Lilypadpositions[5] = Lilypadpositions[4] + Vertical;
		Lilypadpositions[6] = Lilypadpositions[5] - Horizontal;
		Lilypadpositions[7] = Lilypadpositions[6] + Vertical;
		Lilypadpositions[8] = Lilypadpositions[7] + Vertical;
		Lilypadpositions[9] = Lilypadpositions[8] + Vertical;
		spawnLilyPad(0, 0);
		spawnLilyPad(0, 1);
		spawnLilyPad(0, 2);
		spawnLilyPad(0, 3);
		spawnLilyPad(0, 4);
		spawnLilyPad(0, 5);
		spawnLilyPad(0, 6);
		spawnLilyPad(0, 7);
		spawnLilyPad(0, 8);
		spawnLilyPad(0, 9);
	}

	void LevelThree() {
		numberOfLilypads = 26;
		Lilypad = new GameObject[numberOfLilypads];
		Lilypadpositions = new Vector3[numberOfLilypads];
		Lilypadpositions[0] = GameObject.FindGameObjectsWithTag("Water")[0].transform.position + new Vector3(-3.2f, 1.2f, -5.0f);
		Lilypadpositions[1] = Lilypadpositions[0] + Horizontal;
		Lilypadpositions[2] = Lilypadpositions[0] - Horizontal;
		Lilypadpositions[3] = Lilypadpositions[1] + Vertical;
		Lilypadpositions[4] = Lilypadpositions[2] + Vertical;
		Lilypadpositions[5] = Lilypadpositions[3] + Vertical;
		Lilypadpositions[6] = Lilypadpositions[4] + Vertical;
		Lilypadpositions[7] = Lilypadpositions[5] + Vertical;
		Lilypadpositions[8] = Lilypadpositions[6] + Vertical;
		Lilypadpositions[9] = Lilypadpositions[7] + Vertical + Vertical + Vertical;
		Lilypadpositions[10] = Lilypadpositions[8] + Vertical + Vertical + Vertical;
		Lilypadpositions[11] = Lilypadpositions[9] + Vertical;
		Lilypadpositions[12] = Lilypadpositions[10] + Vertical;
		Lilypadpositions[13] = Lilypadpositions[11] + Vertical;
		Lilypadpositions[14] = Lilypadpositions[12] + Vertical;
		Lilypadpositions[15] = Lilypadpositions[14] + Horizontal;
		Lilypadpositions[16] = Lilypadpositions[14] + Vertical;
		Lilypadpositions[17] = Lilypadpositions[13] + Vertical;
		Lilypadpositions[18] = Lilypadpositions[16] + Vertical;
		Lilypadpositions[19] = Lilypadpositions[17] + Vertical;
		Lilypadpositions[20] = Lilypadpositions[18] + Vertical;
		Lilypadpositions[21] = Lilypadpositions[19] + Vertical;
		Lilypadpositions[22] = Lilypadpositions[20] + Vertical;
		Lilypadpositions[23] = Lilypadpositions[21] + Vertical;
		Lilypadpositions[24] = Lilypadpositions[22] + Vertical;
		Lilypadpositions[25] = Lilypadpositions[23] + Vertical;
		spawnLilyPad(0, 0);
		spawnLilyPad(0, 1);
		spawnLilyPad(0, 2);
		spawnLilyPad(0, 3);
		spawnLilyPad(0, 4);
		spawnLilyPad(0, 5);
		spawnLilyPad(0, 6);
		spawnLilyPad(0, 7);
		spawnLilyPad(0, 8);
		spawnLilyPad(0, 9);
		spawnLilyPad(0, 10);
		spawnLilyPad(0, 11);
		spawnLilyPad(0, 12);
		spawnLilyPad(0, 13);
		spawnLilyPad(0, 14);
		spawnLilyPad(0, 15);
		spawnLilyPad(0, 16);
		spawnLilyPad(0, 17);
		spawnLilyPad(0, 18);
		spawnLilyPad(0, 19);
		spawnLilyPad(0, 20);
		spawnLilyPad(0, 21);
		spawnLilyPad(0, 22);
		spawnLilyPad(0, 23);
		spawnLilyPad(0, 24);
		spawnLilyPad(0, 25);
	}

	void LevelFour() {
		numberOfLilypads = 40;
		Lilypad = new GameObject[numberOfLilypads];
		Lilypadpositions = new Vector3[numberOfLilypads];
		Lilypadpositions[0] = GameObject.FindGameObjectsWithTag("Water")[0].transform.position + new Vector3(-3.2f, 1.2f, -5.0f);
		Lilypadpositions[1] = Lilypadpositions[0] + Vertical;
		Lilypadpositions[2] = Lilypadpositions[1] + Vertical + Vertical + Vertical + Horizontal + Horizontal;
		Lilypadpositions[3] = Lilypadpositions[2] + Vertical;
		Lilypadpositions[4] = Lilypadpositions[3] + Vertical + Vertical + Vertical + Horizontal + Horizontal + Horizontal;
		Lilypadpositions[5] = Lilypadpositions[4] + Vertical;
		Lilypadpositions[6] = Lilypadpositions[5] + Vertical;
		Lilypadpositions[7] = Lilypadpositions[6] + Vertical;
		Lilypadpositions[8] = Lilypadpositions[7] - Horizontal;
		Lilypadpositions[9] = Lilypadpositions[8] - Horizontal;
		Lilypadpositions[10] = Lilypadpositions[9] + Vertical;
		Lilypadpositions[11] = Lilypadpositions[10] + Vertical;
		Lilypadpositions[12] = Lilypadpositions[11] + Vertical;
		Lilypadpositions[13] = Lilypadpositions[12] - Horizontal;
		Lilypadpositions[14] = Lilypadpositions[13] - Horizontal;
		Lilypadpositions[15] = Lilypadpositions[14] - Vertical;
		Lilypadpositions[16] = Lilypadpositions[15] - Vertical;
		Lilypadpositions[17] = Lilypadpositions[16] - Horizontal;
		Lilypadpositions[18] = Lilypadpositions[17] - Horizontal;
		Lilypadpositions[19] = Lilypadpositions[18] + Vertical;
		Lilypadpositions[20] = Lilypadpositions[19] + Vertical;
		Lilypadpositions[21] = Lilypadpositions[20] + Vertical;
		Lilypadpositions[22] = Lilypadpositions[21] + Vertical;
		Lilypadpositions[23] = Lilypadpositions[22] + Horizontal;
		Lilypadpositions[24] = Lilypadpositions[23] + Horizontal;
		Lilypadpositions[25] = Lilypadpositions[24] + Vertical;
		Lilypadpositions[26] = Lilypadpositions[25] + Vertical;
		Lilypadpositions[27] = Lilypadpositions[26] + Vertical;
		Lilypadpositions[28] = Lilypadpositions[27] + Horizontal;
		Lilypadpositions[29] = Lilypadpositions[28] + Horizontal;
		Lilypadpositions[30] = Lilypadpositions[29] + Vertical;
		Lilypadpositions[31] = Lilypadpositions[30] + Vertical;
		Lilypadpositions[32] = Lilypadpositions[31] + Vertical;
		Lilypadpositions[33] = Lilypadpositions[32] + Vertical;
		Lilypadpositions[34] = Lilypadpositions[33] + Vertical;
		Lilypadpositions[35] = Lilypadpositions[34] - Horizontal;
		Lilypadpositions[36] = Lilypadpositions[35] - Horizontal;
		Lilypadpositions[37] = Lilypadpositions[36] + Vertical;
		Lilypadpositions[38] = Lilypadpositions[37] + Vertical;
		Lilypadpositions[39] = Lilypadpositions[38] + Vertical;
		for(int i = 0; i < Lilypadpositions.Length; i++) {
			spawnLilyPad(0, i);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
