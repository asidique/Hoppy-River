using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GameMaster : MonoBehaviour {

	public int leafs;
	public int level;
	Text numberOfLeafs;
	Text levelNumber;
	Text timeElapsed;
	Text timeElapsedEnd;
	Text timeElapsedWin;
	FrogControls frogControls;
	float roundTime;
	public int numberOfStars;


	// Use this for initialization
	void Start () {
		numberOfStars = 0;
		leafs = 0;
		roundTime = 0f;
		timeElapsed = GameObject.Find("TimeText").GetComponent<Text>();
		timeElapsedWin = GameObject.Find("TimeTextShadow2").GetComponent<Text>();
		numberOfLeafs = GameObject.Find("NumberOfLeafs").GetComponent<Text>();
		levelNumber = GameObject.Find("LevelNumber").GetComponent<Text>();
		timeElapsedEnd = GameObject.Find("TimeTextShadow").GetComponent<Text>();
		frogControls = GameObject.FindObjectOfType<FrogControls>();
		SetUIOn(true);
		SetLoseOn(false);
		SetWinOn(false);

		if(Application.loadedLevel == 1) {
			levelNumber.text = "1";
		} else if(Application.loadedLevel == 2) {
			levelNumber.text = "2";
		}
	}
	
	// Update is called once per frame
	void Update () {
		timeElapsed.text = Math.Round(roundTime, 2).ToString() + "s";
		numberOfLeafs.text = leafs.ToString();
		if(frogControls.playerDead == true && frogControls.winRound == false) {
			timeElapsedEnd.text = timeElapsed.text;
			SetUIOn(false);
			SetWinOn(false);
			SetLoseOn(true);
		} else if(frogControls.winRound == true && frogControls.playerDead == false) {
			timeElapsedWin.text = timeElapsed.text;
			SetUIOn(false);
			SetLoseOn(false);
			SetWinOn(true);
			if(roundTime < 15f) {
				GameObject.Find("Stars").GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/StarIconFull");
			} else if(roundTime < 30f) {
				GameObject.Find("Stars").GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/StarIconTwo");
			} else if(roundTime < 45f) {
				GameObject.Find("Stars").GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/StarIconOne");
			} else {
				GameObject.Find("Stars").GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/StarIconNone");
			}
		} else {
			roundTime += Time.deltaTime;
		}
	}

	void SetUIOn(bool OnOrOff) {
		for(int i = 0; i < GameObject.Find("UI").GetComponentsInChildren<Image>().Length; i++) {
			GameObject.Find("UI").GetComponentsInChildren<Image>()[i].enabled = OnOrOff;
		}
		for(int i = 0; i < GameObject.Find("UI").GetComponentsInChildren<Button>().Length; i++) {
			GameObject.Find("UI").GetComponentsInChildren<Button>()[i].enabled = OnOrOff;
		}
		for(int i = 0; i < GameObject.Find("UI").GetComponentsInChildren<Text>().Length; i++) {
			GameObject.Find("UI").GetComponentsInChildren<Text>()[i].enabled = OnOrOff;
		}
	}

	void SetWinOn(bool OnOrOff) {
		for(int i = 0; i < GameObject.Find("Win").GetComponentsInChildren<Image>().Length; i++) {
			GameObject.Find("Win").GetComponentsInChildren<Image>()[i].enabled = OnOrOff;
		}
		for(int i = 0; i < GameObject.Find("Win").GetComponentsInChildren<Button>().Length; i++) {
			GameObject.Find("Win").GetComponentsInChildren<Button>()[i].enabled = OnOrOff;
		}
		for(int i = 0; i < GameObject.Find("Win").GetComponentsInChildren<Text>().Length; i++) {
			GameObject.Find("Win").GetComponentsInChildren<Text>()[i].enabled = OnOrOff;
		}
	}


	void SetLoseOn(bool OnOrFalse) {
		for(int i = 0; i < GameObject.Find("Lose").GetComponentsInChildren<Image>().Length; i++) {
			GameObject.Find("Lose").GetComponentsInChildren<Image>()[i].enabled = OnOrFalse;
		}
		for(int i = 0; i < GameObject.Find("Lose").GetComponentsInChildren<Button>().Length; i++) {
			GameObject.Find("Lose").GetComponentsInChildren<Button>()[i].enabled = OnOrFalse;
		}
		for(int i = 0; i < GameObject.Find("Lose").GetComponentsInChildren<Text>().Length; i++) {
			GameObject.Find("Lose").GetComponentsInChildren<Text>()[i].enabled = OnOrFalse;
		}
	}


	public void RestartLevel() {
		if(Application.loadedLevel == 1) {
			Application.LoadLevel(1);
		} else if(Application.loadedLevel == 2) {
			Application.LoadLevel(2);
		} else if(Application.loadedLevel == 3) {
			Application.LoadLevel(3);
		}
	}

	public void NextLevel() {
		int i = Application.loadedLevel;
		i++;
		Application.LoadLevel(i);
	}

	public void GoHome() {
		Application.LoadLevel (0);
	}
}
