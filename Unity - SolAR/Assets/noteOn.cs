using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteOn : MonoBehaviour {

	public AudioHelm.HelmController helmController;
	public int midiNote;
	public float velocity;
	

	// Use this for initialization
	void Start () {
	startNote();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void startNote (){

		helmController.NoteOn(midiNote, velocity, 5.0f);

	}
}
