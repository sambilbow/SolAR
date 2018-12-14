using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class celestialObjectInstantiatorCreator : MonoBehaviour {

	public Slider slider;
	public GameObject audioManager;
	public GameObject celestialObject;
	
	
	public void generate () 
	{
			
		for(int i = 0; i < slider.value; i++)
		{

			Transform celestialDialogue = GameObject.Find("celestialDialogue"+i).gameObject.transform;
			

			string celestialName = celestialDialogue.Find("celestialName").gameObject.GetComponent<Text>().text;
			float celestialBodyDistance = celestialDialogue.Find("distanceSlider").gameObject.GetComponent<Slider>().value;
			float celestialOrbitalFrequency = celestialDialogue.Find("orbitalSlider").gameObject.GetComponent<logSlider>().newValue;
			float celestialRotationalFrequency = celestialDialogue.Find("rotationalSlider").gameObject.GetComponent<logSlider>().newValue;
			float celestialBodyDiameter = celestialDialogue.Find("diameterSlider").gameObject.GetComponent<Slider>().value;
			float celestialBodyTemperature = celestialDialogue.Find("temperatureSlider").gameObject.GetComponent<Slider>().value;

			// Instantiate celestialObject prefab
			var instantiatedCelestial = Instantiate(celestialObject, new Vector3(0,0,0),Quaternion.identity);
			// Define properties script for ease of code
			var celProps = instantiatedCelestial.GetComponent<celestialProperties>();
			// Set name of instantiated prefab
			instantiatedCelestial.gameObject.name = ("celestialObject"+i);
			// Set parent of instantiated prefab
			instantiatedCelestial.transform.SetParent(this.gameObject.transform);

			// Randomise properties of the instantiated celestialObject prefab
			celProps.celestialName = celestialName;
			celProps.celestialID = i;
			// Set distance from centre as i (celestialObject number) + a float value. This ensures that 0 is closest, and x where x = amountOfCelestials is the furthest.
			celProps.celestialBodyDistance = celestialBodyDistance;
			celProps.celestialOrbitFrequency = celestialOrbitalFrequency;
			celProps.celestialRotationalFrequency = celestialRotationalFrequency;
			celProps.celestialBodyDiameter = celestialBodyDiameter;
			celProps.celestialBodyTemperature = celestialBodyTemperature;
			celProps.celestialOrbitAxis = new Vector3(0,1,0);				

			// Store initial values for these two so that scaling doesnt multiply by itself
			celProps.celestialInitOrbitFrequency = celProps.celestialOrbitFrequency;
			celProps.celestialInitRotationalFrequency = celProps.celestialRotationalFrequency;
		}

		audioManager.SetActive(true);
		
	
	}
}
