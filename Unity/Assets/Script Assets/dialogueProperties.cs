using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueProperties : MonoBehaviour {

	public int ID;

	public string celestialName = "default";
	public float celestialBodyDistance = 0;
	public float celestialOrbitalFrequency = 0;
	public float celestialRotationalFrequency = 0;
	public float celestialBodyDiameter = 0;
	public float celestialBodyTemperature = 0;

	public GameObject celestialNameField;
	public Slider distanceSlider;
	public Slider orbitalSlider;
	public Slider rotationalSlider;
	public Slider diameterSlider;
	public Slider temperatureSlider;



	void Update()

	{
		string celestialNameText = celestialNameField.GetComponent<Text>().text;

		celestialName = celestialNameText;
		celestialBodyDistance = distanceSlider.value;
		celestialOrbitalFrequency = orbitalSlider.GetComponent<logSlider>().newValue;
		celestialRotationalFrequency = rotationalSlider.GetComponent<logSlider>().newValue;
		celestialBodyDiameter = diameterSlider.value;
		celestialBodyTemperature = temperatureSlider.value;
	}	
}
