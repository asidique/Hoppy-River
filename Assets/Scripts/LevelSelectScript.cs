using UnityEngine;
using System.Collections;

public class LevelSelectScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartLevelOne() {
		Application.LoadLevel(1);
	}

	public void StartLevelTwo() {
		Application.LoadLevel(2);
	}

	public void StartLevelThree() {
		Application.LoadLevel(3);
	}
}
