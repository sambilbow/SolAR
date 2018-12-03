using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audioPreviewManager : MonoBehaviour {

	public AudioMixer systemMixer;

	// Use this for initialization
	void Update () 
	{
		string masterMix = "Master";
		
		GameObject preview = GameObject.Find("preview").gameObject;

		preview.GetComponent<AudioSource>().outputAudioMixerGroup = systemMixer.FindMatchingGroups(masterMix)[16];
	}
	
}
