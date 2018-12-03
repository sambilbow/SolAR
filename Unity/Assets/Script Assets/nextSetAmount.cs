using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextSetAmount : MonoBehaviour {

	public GameObject slider;
	public GameObject dialogueManager;
	public GameObject celestialManager;
	public GameObject audioManager;
	public GameObject celestialObject;
	
	// Use this for initialization
	public void nextButtonDialogue (bool onOff) {

		if(onOff == true)
		{
			dialogueManager.GetComponent<celestialDialogueInstantiator>().makeDialogue(Mathf.RoundToInt(slider.GetComponent<Slider>().value));
			
		}
	}

	public void nextButtonCelestials (bool onOff) {
		if(onOff == true)
		{
			
			
			audioManager.SetActive(true);
			AudioListener.pause = true;
			

			for(int i = 0; i < slider.GetComponent<Slider>().value; i++)
			{

				Transform celestialDialogue = GameObject.Find("celestialDialogue"+i.ToString()).gameObject.transform;

				string celestialName = celestialDialogue.GetChild(2).GetComponent<Text>().text;
				float celestialBodyDistance = celestialDialogue.GetChild(4).GetComponent<Slider>().value;
				float celestialOrbitalFrequency = celestialDialogue.GetChild(6).GetComponent<Slider>().value;
				float celestialRotationalFrequency = celestialDialogue.GetChild(8).GetComponent<Slider>().value;
				float celestialBodyDiameter = celestialDialogue.GetChild(10).GetComponent<Slider>().value;
				float celestialBodyTemperature = celestialDialogue.GetChild(12).GetComponent<Slider>().value;

				// Instantiate celestialObject prefab
				var instantiatedCelestial = Instantiate(celestialObject, new Vector3(0,0,0),Quaternion.identity);
				// Define properties script for ease of code
				var celProps = instantiatedCelestial.GetComponent<celestialProperties>();
				// Set name of instantiated prefab
				instantiatedCelestial.gameObject.name = ("celestialObject"+i.ToString());
				// Set parent of instantiated prefab
				instantiatedCelestial.transform.SetParent(GameObject.Find("celestialManager").transform);

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
		}
	}
}
