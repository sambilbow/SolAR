using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteOn : MonoBehaviour {

	// Define public variables and initiate Helm synth
	public AudioHelm.HelmController helmController;
	public int midiNote;
	public float velocity;


	// Use this for initialization
	void Start ()
	{
		// Run startNote function after 0.1s
		Invoke("startNote",0.1f);
	}

	// Function that calls midi note on with defined note value and velocity
	void startNote ()
	{
		// Note on with defined values
		helmController.NoteOn(midiNote, velocity);
	}
}
