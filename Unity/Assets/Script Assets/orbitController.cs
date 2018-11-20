using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitController : MonoBehaviour {

	public float rotateSpeed = 1.0f;
	public Vector3 spinAxis  = new Vector3(0,1,0);
	
	

	// Use this for initialization
	void Start () {
	
	Transform attachedObject = this.gameObject.GetComponent<Transform>();
	// Get orbit radius from Z position of script-parent gameObject
	float orbitalRadius = attachedObject.transform.position.z;
	
	// Translate Vector2
	Vector2 randomPositionOnCircle = RandomOnUnitCircle2(orbitalRadius);
	float posX = randomPositionOnCircle.x;
	float posZ = randomPositionOnCircle.y;

	// Place gameObject at random point on circle with y=0
	attachedObject.transform.position = new Vector3 (posX,0,posZ);

	}
	
	// Function that makes a random Vector2 transform on the circumference of the given orbitRadius.
	public static Vector2 RandomOnUnitCircle2(float orbitalRadius) 
    {
        Vector2 randomPointOnCircle = Random.insideUnitCircle;
        randomPointOnCircle.Normalize();
        randomPointOnCircle *= orbitalRadius;
        return randomPointOnCircle;
    }

	// Update is called once per frame
	void Update () {

	this.transform.RotateAround(Vector3.zero,spinAxis,rotateSpeed);	

	}


}
