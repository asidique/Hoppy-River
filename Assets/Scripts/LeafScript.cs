using UnityEngine;
using System.Collections;

public class LeafScript : MonoBehaviour {

	GameMaster gameMaster;

	// Use this for initialization
	void Start () {
		gameMaster = GameObject.FindObjectOfType<GameMaster>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles += new Vector3(0, Time.deltaTime * 120f, 0);
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Player") {
			gameMaster.leafs++;
			Destroy(gameObject);
		}
	}
}
