using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioHelm;

public class parameterController : MonoBehaviour {

	
	
	

	void Update () {

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
		
		// Scales LFO 1 frequency to orbit frequency (osc 1 + 2 amt)
		controller.SetParameterAtIndex(0,scale(celestialOrbitFrequency,0.001f,1000f,0f,1f));
		// Scales LFO 2 frequency to rotational frequency (filter resonance %)
		controller.SetParameterAtIndex(1,scale(celestialRotationalFrequency,0.001f,1000f,0f,1f));
		// Scales filter cutoff to temperature
		controller.SetParameterAtIndex(2,scale(celestialBodyTemperature,0f,4000f,0.25f,1f));
		// Scales filter drive by size
		controller.SetParameterAtIndex(3,scale(celestialBodyDiameter,0.001f,1f,0f,0.25f));
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
