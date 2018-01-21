using UnityEngine;
using System.Collections;

public class FrogControls : MonoBehaviour {

	public float percent;
	public float lerpTime, currentLerpTime;
	//public float timeTo100;

	public GameObject Checkcolliderfront, Checkcolliderback, Checkcolliderright, Checkcolliderleft;
	public Vector3 startPosition, endPosition;

	public bool firstInput, isJumping;

	public float playerMovement;
	public bool FrontBlock, BackBlock, RightBlock, LeftBlock;
	public bool sinking, splat, playerDead, winRound;

	// Use this for initialization
	void Start () {
		percent = 1f;
		isJumping = false;
		currentLerpTime = 0f;
		firstInput = true;
		playerMovement = 10f;
		//startPosition = new Vector3(-3.7f, 0.53f, -7.5f);
		Checkcolliderfront = GameObject.Find("CheckColliderFront");
		Checkcolliderback = GameObject.Find("CheckColliderBack");
		Checkcolliderright = GameObject.Find("CheckColliderRight");
		Checkcolliderleft = GameObject.Find("CheckColliderLeft");

		sinking = false;
		splat = false;
		FrontBlock = false;
		BackBlock = false;
		RightBlock = false;
		LeftBlock = false;
		playerDead = false;
		winRound = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(Application.loadedLevel != 0) {
			Checkcolliderfront.transform.position = this.gameObject.transform.position + new Vector3(0f, 0f, 10);
			Checkcolliderback.transform.position = this.gameObject.transform.position + new Vector3(0f, 0f, -10);
			Checkcolliderright.transform.position = this.gameObject.transform.position + new Vector3(10f, 0f, 0f);
			Checkcolliderleft.transform.position = this.gameObject.transform.position + new Vector3(-10f, 0f, 0);
		}


		if(Input.GetButtonDown("Up") || Input.GetButtonDown("Down") || Input.GetButtonDown("Left") || Input.GetButtonDown("Right")) {
			if(percent >= 1) {
				lerpTime = 0.20f;
				currentLerpTime = 0f;
				firstInput = true;
			}
		}

		startPosition = this.gameObject.transform.position;
		playerInput();


		if(firstInput) {
			if(startPosition != endPosition) {
			currentLerpTime += Time.deltaTime * 2;
			} else {
				currentLerpTime = 0;
			}
			percent = currentLerpTime/lerpTime;
			gameObject.transform.position = Vector3.Lerp(startPosition, endPosition, percent);
		
			if(percent > 0.5f) {
				isJumping = false;
			}
		}
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Sink") {
			sinking = true;
			playerDead = true;
		} else if(col.gameObject.tag == "Shark" || col.gameObject.tag == "Snake") {
			splat = true;
			playerDead = true;
		} else if(col.gameObject.tag == "Finish") {
			winRound = true;
		}
	}

	void playerInput() {
		if(Input.GetButtonDown("Up") && transform.position == endPosition && !sinking && !splat) {
			this.gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
			if(!FrontBlock) {
			isJumping = true;
			endPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + playerMovement);
			}
		}
		
		if(Input.GetButtonDown("Down") && transform.position == endPosition && !sinking && !splat) {
			this.gameObject.transform.eulerAngles = new Vector3(0, 270, 0);				
			if(!BackBlock) {
			isJumping = true;
			endPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z - playerMovement);
			}
		}
		
		if(Input.GetButtonDown("Right") && transform.position == endPosition && !sinking && !splat) {
			this.gameObject.transform.eulerAngles = new Vector3(0, 180, 0);				
			if(!RightBlock) {
			isJumping = true;
			endPosition = new Vector3(transform.position.x + playerMovement, transform.position.y, transform.position.z);
			}
		}
		
		if(Input.GetButtonDown("Left") && transform.position == endPosition && !sinking && !splat) {
			this.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);				
			if(!LeftBlock) {
			isJumping = true;
			endPosition = new Vector3(transform.position.x - playerMovement, transform.position.y, transform.position.z);
			}
		}
	}
}
