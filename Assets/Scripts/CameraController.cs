using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (transform.rotation != new Quaternion(40,0,0,0))
			transform.rotation = new Quaternion(40,0,0,0);
	}
}
