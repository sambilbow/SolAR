using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioHelm;

public class parameterController : MonoBehaviour {

	
	
	// Use this for initialization
	void Start () {

		// Lets find all of the usable parameters
		var celProps = this.gameObject.GetComponent<celestialProperties>();
		
		string celestialName = celProps.celestialName;
		int celestialID = celProps.celestialID;
		float celestialBodyDistance = celProps.celestialBodyDistance;
		float celestialOrbitFrequency = celProps.celestialOrbitFrequency;
		float celestialRotationalFrequency = celProps.celestialRotationalFrequency;
		float celestialBodyDiameter = celProps.celestialBodyDiameter;
		float celestialBodyTemperature = celProps.celestialBodyTemperature;
				
			
		
		// Setting parameters scaled to percentages
		HelmController controller = this.gameObject.GetComponent<AudioHelm.HelmController>();
		
		// Scales LFO 1 frequenc
		controller.SetParameterAtIndex(1,scale(celestialOrbitFrequency,0.1f,180f,0f,1f));
		controller.SetParameterAtIndex(2,scale(celestialRotationalFrequency,0.1f,300f,0f,1f));
		controller.SetParameterAtIndex(3,scale(celestialBodyTemperature,0f,4000f,0.5f,1f));

	}
	
	
	// Function that scales input to a float percentage.
	float scale (float input, float oldMin, float oldMax, float newMin, float newMax)
	{
		float oldRange = (oldMax - oldMin);
		float newRange = (newMax - newMin);

		float output = (((input - oldMin) * newRange) / oldRange) + newMin;
		
		return output;
	}
}
