using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitController : MonoBehaviour {

	public float rotateSpeed = 1.0f;
	public Vector3 spinAxis  = new Vector3(0,1,0);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	this.transform.RotateAround(Vector3.zero,spinAxis,rotateSpeed);	

	}

	void rotate () {

	

	}
}
