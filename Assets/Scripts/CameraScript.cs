using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public float delay;
	Transform player;
	public float zAxis, xAxis;
	public float velocityx;
	public float timex;
	public float timey;
	public float velocityy;

	// Use this for initialization
	void Start () {
		velocityy = 1f;
		timey = 0.38f;
		velocityx = 1f;
		timex = 0.38f;
		player = GameObject.Find("forg").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		zAxis = Mathf.SmoothDamp(transform.position.z, player.position.z, ref velocityx, timex);
		xAxis = Mathf.SmoothDamp(transform.position.x, player.position.x, ref velocityy, timey);
		transform.position = new Vector3(xAxis, transform.position.y, zAxis);
	}
}
