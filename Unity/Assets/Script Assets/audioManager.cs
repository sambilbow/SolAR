using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audioManager : MonoBehaviour {

	public AudioMixer systemMixer;

	// Use this for initialization
	void Start () {
		
		int amountOfCelestials = GameObject.Find("celestialManager").gameObject.GetComponent<celestialObjectInstatiator>().amountOfCelestials;

		for(int i = 0; i < amountOfCelestials; i++)
		{
			GameObject celestialObject = GameObject.Find("celestialObject"+i).gameObject;
			string masterMix = "Master";

			celestialObject.GetComponent<AudioSource>().outputAudioMixerGroup = systemMixer.FindMatchingGroups(masterMix)[i];
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
