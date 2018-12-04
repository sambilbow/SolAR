using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class celestialObjectInstatiatorForCreate : MonoBehaviour {

	// Define prefab to instantiate
	public GameObject celestialObject;
    public GameObject createSystemName;
    public GameObject systemTitle;
	// Define int that holds the number of celestials to be instantiated
	
	
	void Start()
    {
        
    }

	
	public void generate(int amountOfCelestials) 
	{
		systemTitle.GetComponent<Text>().text = createSystemName.GetComponent<Text>().text;
		
        makeCelestial(amountOfCelestials);	
	}








	// Update is called once per frame
	void Update () 
	{
		
	}





	// Use this for instantiation
	public void makeCelestial (int amountOfCelestials) 
	{
		// For loop that instantiates x amount of celestials where x = defined int above.
		for(int i = 0; i < amountOfCelestials; i++)
		{	
			// Instantiate celestialObject prefab
			var instantiatedCelestial = Instantiate(celestialObject, new Vector3(0,0,0),Quaternion.identity);
			// Define properties script for ease of code
			var celProps = instantiatedCelestial.GetComponent<celestialProperties>();
			// Set name of instantiated prefab
			instantiatedCelestial.gameObject.name = ("celestialObject"+i);
			// Set parent of instantiated prefab
			instantiatedCelestial.transform.SetParent(GameObject.Find("celestialManager").transform);
			
			// Randomise properties of the instantiated celestialObject prefab
			celProps.celestialName = "default";
			celProps.celestialID = i;
			// Set distance from centre as i (celestialObject number) + a float value. This ensures that 0 is closest, and x where x = amountOfCelestials is the furthest.
			celProps.celestialBodyDistance = i+1 + Random.Range(0f,0.9f);
			celProps.celestialOrbitFrequency = Random.Range(0.1f,180f);
			celProps.celestialRotationalFrequency = Random.Range(0.1f,300f);
			celProps.celestialBodyDiameter = Random.Range(0.00f,1f);
			celProps.celestialBodyTemperature = Random.Range(0f,4000f);
			celProps.celestialOrbitAxis = new Vector3(0,1,0);

			// Store initial values for these two so that scaling doesnt multiply by itself
			celProps.celestialInitOrbitFrequency = celProps.celestialOrbitFrequency;
			celProps.celestialInitRotationalFrequency = celProps.celestialRotationalFrequency;
		}
	}
}
