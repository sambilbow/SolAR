using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioHelm;

public class parameterController : MonoBehaviour {

	
	
	// Use this for initialization
	void Start () {

		// Lets find all of the usable parameters

		// Find object diameter from rectTransform scale.	
		Transform objectTransform = this.gameObject.GetComponent<Transform>();
		float objectDiameter = objectTransform.localScale.x;
		Debug.Log(objectDiameter);

		// Find object orbital and rotational frequencies from orbital controller script.
		var orbitControllerScript = this.gameObject.GetComponent<orbitController>();
		float objectOrbitalFrequency = orbitControllerScript.orbitSpeed;
		float objectRotationalFrequency = orbitControllerScript.rotateSpeed;

		
		// Setting parameters
		HelmController controller = this.gameObject.GetComponent<AudioHelm.HelmController>();
		
		//controller.SetParameterAtIndex(1,);
		//controller.SetParameterAtIndex(2,);
		//controller.SetParameterAtIndex(3,);

	}
	
	
}
