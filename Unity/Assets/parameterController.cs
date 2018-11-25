using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioHelm;

public class parameterController : MonoBehaviour {

	
	
	// Use this for initialization
	void Start () {

		// Lets find all of the 

		// Find object diameter from rectTransform scale.	
		RectTransform objectRectTransform = this.gameObject.GetComponent<RectTransform>();
		float objectDiameter = objectRectTransform.localScale.x;

		// Find object orbital and rotational frequencies from orbital controller script.
		var orbitControllerScript = this.gameObject.GetComponent<orbitController>();
		float objectOrbitalFrequency = orbitControllerScript.orbitSpeed;
		float objectRotationalFrequency = orbitControllerScript.rotateSpeed;

		
		// Setting parameters
		HelmController controller = this.gameObject.GetComponent<AudioHelm.HelmController>();
		
		controller.SetParameterAtIndex(1,);
		controller.SetParameterAtIndex(2,);
		controller.SetParameterAtIndex(3,);

	}
	
	
}
