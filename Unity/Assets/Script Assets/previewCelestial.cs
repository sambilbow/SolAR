using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class previewCelestial : MonoBehaviour {


	public GameObject celestialName;
	public GameObject distanceSlider;
	public GameObject oFreqSlider;
	public GameObject rFreqSlider;	
	public GameObject diameterSlider;
	public GameObject tempSlider;
	public Button previewButton;
	public AudioMixer systemMixer;
	
	void Start () 
	{
		previewButton.onClick.AddListener(TaskOnClick);	
	}
	
	void TaskOnClick()
	{

		GameObject preview = GameObject.Find("celestialPreviewManager").gameObject.transform.GetChild(0).gameObject;
				
		
		float distanceSliderValue = distanceSlider.GetComponent<Slider>().value;
		float oFreqSliderValue = oFreqSlider.GetComponent<logSlider>().newValue;
		float rFreqSliderValue = rFreqSlider.GetComponent<logSlider>().newValue;
		float diameterSliderValue = diameterSlider.GetComponent<Slider>().value;
		float tempSliderValue = tempSlider.GetComponent<Slider>().value;

		var celProps = preview.GetComponent<celestialProperties>();
		celProps.celestialBodyDistance = distanceSliderValue;
		celProps.celestialOrbitFrequency = oFreqSliderValue;
		celProps.celestialRotationalFrequency = rFreqSliderValue;
		celProps.celestialBodyDiameter = diameterSliderValue;
		celProps.celestialBodyTemperature = tempSliderValue;
		

		string masterMix = "Master";
		preview.GetComponent<AudioSource>().outputAudioMixerGroup = systemMixer.FindMatchingGroups(masterMix)[16];
		preview.GetComponent<AudioSource>().mute = false;
	}
}
