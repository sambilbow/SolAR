using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audioManager : MonoBehaviour {

	public AudioMixer systemMixer;

	// Use this for initialization
	void Start () 
	{	
		// Find amount of celestials in scene
		int amountOfCelestials = GameObject.Find("celestialManager").gameObject.GetComponent<celestialObjectInstatiator>().amountOfCelestials;
		
		// For each celestial, assign corresponding audio mixer group based on celestialID/i (essentially the same value)
		for(int i = 0; i < amountOfCelestials; i++)
		{
			GameObject celestialObject = GameObject.Find("celestialObject"+i).gameObject;
			string masterMix = "Master";

			celestialObject.GetComponent<AudioSource>().outputAudioMixerGroup = systemMixer.FindMatchingGroups(masterMix)[i+1];
		}


	}
}
