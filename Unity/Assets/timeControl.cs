using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeControl : MonoBehaviour {

	public GameObject mercury;
	public GameObject venus;
	public GameObject earth;
	public GameObject mars;
	public GameObject jupiter;
	public GameObject saturn;
	public GameObject uranus;
	public GameObject neptune;
	
	 
	
	public void updateMultiplier(float multiplier)
	{
		float defaultMercury = 1.607f;
		float defaultVenus = 1.176f;
		float defaultEarth = 1.000f;
		float defaultMars = 0.809f;
		float defaultJupiter = 0.439f;
		float defaultSaturn = 0.325f;
		float defaultUranus = 0.229f;
		float defaultNeptune = 0.182f;
		mercury.GetComponent<orbitController>().orbitSpeed = defaultMercury*multiplier;
		venus.GetComponent<orbitController>().orbitSpeed = defaultVenus*multiplier;
		earth.GetComponent<orbitController>().orbitSpeed = defaultEarth*multiplier;
		mars.GetComponent<orbitController>().orbitSpeed = defaultMars*multiplier;
		jupiter.GetComponent<orbitController>().orbitSpeed = defaultJupiter*multiplier;
		saturn.GetComponent<orbitController>().orbitSpeed = defaultSaturn*multiplier;
		uranus.GetComponent<orbitController>().orbitSpeed = defaultUranus*multiplier;
		neptune.GetComponent<orbitController>().orbitSpeed = defaultNeptune*multiplier;
	}

	





}
