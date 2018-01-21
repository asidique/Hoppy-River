using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	Animator MenuAnim;
	Animator LevelSelectAnim;
	bool playButton;

	// Use this for initialization
	void Start () {
		MenuAnim = GameObject.Find("MainMenu").GetComponent<Animator>();
		LevelSelectAnim = GameObject.Find("LevelSelect").GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void PlayButton() {
		MenuAnim.SetBool("Swerve", true);
		LevelSelectAnim.SetBool("PlayButton", true);
	}
}
