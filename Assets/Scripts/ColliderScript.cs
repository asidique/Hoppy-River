using UnityEngine;
using System.Collections;

public class ColliderScript : MonoBehaviour {

	FrogControls frogControls;
	// Use this for initialization
	void Start () {
		frogControls = GameObject.FindObjectOfType<FrogControls>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay(Collider col) {
		if(this.name == "CheckColliderFront") {
			if(col.gameObject.tag == "Unwalkable") {
			frogControls.FrontBlock = true;
			} else {
				frogControls.FrontBlock = false;
			}
		}

		if(this.name == "CheckColliderBack") {
			if(col.gameObject.tag == "Unwalkable") {
			frogControls.BackBlock = true;
			} else {
				frogControls.BackBlock = false;
			}
		}

		if(this.name == "CheckColliderRight") {
			if(col.gameObject.tag == "Unwalkable") {
			frogControls.RightBlock = true;
			} else {
				frogControls.RightBlock = false;
			}
		}

		if(this.name == "CheckColliderLeft") {
			if(col.gameObject.tag == "Unwalkable") {
			frogControls.LeftBlock = true;
			} else {
				frogControls.LeftBlock = false;
			}
		}
	}

}
