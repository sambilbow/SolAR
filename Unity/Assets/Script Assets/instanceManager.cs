using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instanceManager : MonoBehaviour {

	// Attach celestial object prefab
	public GameObject celestialObjectPrefab;
	// Attach celestial dialogue prefab
	public GameObject celestialDialoguePrefab;
	// Attach celestial dialogue parent
	public GameObject celestialDialogueParent;
	


	
	// Use this for initialization
	public void makeDialogue (int amountOfCelestials) {
		
		for(int i = 0; i < amountOfCelestials; i++)
		{
			
			// INSTANCED DIALOGUE CODE
		
			// Instance dialogue
			GameObject instancedDialogue = Instantiate(celestialDialoguePrefab,celestialDialogueParent.transform.position,Quaternion.identity);
			// Set dialogue name based on i
			instancedDialogue.gameObject.name = "celestialDialogue"+i.ToString();
			
			// Set parent to x and DONT place relative to with parent transform
			instancedDialogue.transform.SetParent(celestialDialogueParent.transform,false);
			
			// Set inactive
			instancedDialogue.SetActive(false);

			
			// Find properties script attached to dialogue
			var diaProps = instancedDialogue.GetComponent<dialogueProperties>();
			
			
			
			
			
			
			
			// Run instanced object script below with premade properties from slider values.
			makeCelestial(i, diaProps.celestialName,diaProps.celestialBodyDistance,diaProps.celestialOrbitalFrequency, diaProps.celestialRotationalFrequency, diaProps.celestialBodyDiameter, diaProps.celestialBodyTemperature);
		}

	}
	
	// Function that creates an amount of celestials with premade properties
	public void makeCelestial(int ID, string celestialName, float celestialBodyDistance, float celestialOrbitFrequency, float celestialRotationalFrequency, float celestialBodyDiameter, float celestialBodyTemperature)
	{
		// INSTANCED OBJECT CODE
		
		// Instance object
		GameObject instancedCelestial = Instantiate(celestialObjectPrefab, new Vector3 (0,0,0), Quaternion.identity);
		// Set object name based on i
		instancedCelestial.gameObject.name = "celestialObject"+ID.ToString();
		// Set parent to x and DONT place relative to with parent transform
		instancedCelestial.transform.SetParent(this.gameObject.transform,false);
		
		// Find properties script attached to object
		var celProps = instancedCelestial.gameObject.GetComponent<celestialProperties>();
		
		// Assign values to property script based on function input
		celProps.celestialName = celestialName;
		celProps.celestialID = ID;
		celProps.celestialBodyDistance = celestialBodyDistance;
		celProps.celestialOrbitFrequency = celestialOrbitFrequency;
		celProps.celestialRotationalFrequency = celestialRotationalFrequency;
		celProps.celestialBodyDiameter = celestialBodyDiameter;
		celProps.celestialBodyTemperature = celestialBodyTemperature;
		celProps.celestialOrbitAxis = new Vector3(0,1,0);				
		
		// Store initial values for these two so that scaling doesnt multiply by itself
		celProps.celestialInitOrbitFrequency = celProps.celestialOrbitFrequency;
		celProps.celestialInitRotationalFrequency = celProps.celestialRotationalFrequency;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
