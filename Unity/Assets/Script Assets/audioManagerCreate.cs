using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class audioManagerCreate : MonoBehaviour {

	public AudioMixer systemMixer;
    public Slider slider;

	// Use this for initialization
	void Start () 
	{	
		// Find amount of celestials in scene
	
		
		// For each celestial, assign corresponding audio mixer group based on celestialID/i (essentially the same value)
		for(int i = 0; i < slider.value; i++)
		{
			GameObject celestialObject = GameObject.Find("celestialObject"+i.ToString()).gameObject;
			string masterMix = "Master";

			celestialObject.GetComponent<AudioSource>().outputAudioMixerGroup = systemMixer.FindMatchingGroups(masterMix)[i+1];

		
		}

	
	}
}


