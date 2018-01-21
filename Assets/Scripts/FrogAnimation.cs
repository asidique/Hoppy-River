using UnityEngine;
using System.Collections;

public class FrogAnimation : MonoBehaviour {

	Animator frogAnimationController;
	FrogControls frogControls;

	// Use this for initialization
	void Start () {
		frogAnimationController = this.gameObject.GetComponent<Animator>();
		frogControls = GameObject.Find ("forg").GetComponent<FrogControls>();
	}
	
	// Update is called once per frame
	void Update () {

		if(frogControls.isJumping) {
			frogAnimationController.SetBool("Jumping", true);
		} else {
			frogAnimationController.SetBool("Jumping", false);
		}

		if(frogControls.sinking) {
			frogAnimationController.SetBool("Sinking", true);
		} else {
			frogAnimationController.SetBool("Sinking", false);
		}

		if(frogControls.splat) {
			frogAnimationController.SetBool("Splat", true); 
		} else {
			frogAnimationController.SetBool("Splat", false);
		}

	}
}
