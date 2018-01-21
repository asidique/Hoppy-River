using UnityEngine;
using System.Collections;

public class WaterScript : MonoBehaviour {

	public MeshRenderer waterMaterial;
	public Material waterMat;
	public Vector2 waterMovement;
	public float waterSpeed;
	// Use this for initialization
	void Start () {
		waterMaterial = this.gameObject.GetComponent<MeshRenderer>();
		//waterMovement = new Vector2(1, 0);
		waterSpeed = 0.08f;

	}
	
	// Update is called once per frame
	void Update () {
		if(waterMovement.x <= 10) {
			waterMovement += new Vector2(waterSpeed * Time.deltaTime, 0);
		} else {
			waterMovement = Vector3.zero;
		}

		waterMaterial.materials[0].mainTextureOffset = waterMovement;
	}
}
