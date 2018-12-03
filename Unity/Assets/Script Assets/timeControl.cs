using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeControl : MonoBehaviour {

		 
	public GameObject slider;

	public void updateMultiplier(float multiplier)
	{
		// Find amount of celestials integer from celestial manager gameobejct.
		int amountOfCelestials = GameObject.Find("celestialManager").gameObject.GetComponent<celestialObjectInstatiator>().amountOfCelestials;
		

		for(int i = 0; i < amountOfCelestials; i++)
		{
			// Find instantiated object individually
			GameObject celestialObject = GameObject.Find("celestialObject"+i).gameObject;
			
			
			// Define properties script for ease of code
			var celProps = celestialObject.GetComponent<celestialProperties>();

			// Multiply their rotational and orbital frequencies by slider amount.
			celProps.celestialOrbitFrequency = celProps.celestialInitOrbitFrequency*multiplier;
			celProps.celestialRotationalFrequency = celProps.celestialInitRotationalFrequency*multiplier;


		}
	}

	void Update() 
	{
		
		
	}





}
