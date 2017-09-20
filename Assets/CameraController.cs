using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour{

	public Transform center;
	[Range(-5f, 5f)] public float speed = 1;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(center);
		transform.RotateAround(center.position, center.up, speed);
		
		if(Input.GetKey(KeyCode.LeftArrow)){
			speed -= 0.2f;
		}
		else if (Input.GetKey(KeyCode.RightArrow)) {
			speed += 0.2f;
		}
	}
}
