using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioHelm;

public class sequenceMaker : MonoBehaviour {

	public int increase = 0;
	public int startingNote = 0;
	
	// Use this for initialization
	public void Start () 
	{
		/* Sequencer sequencer = this.gameObject.GetComponent<AudioHelm.Sequencer>();
		sequencer.Clear();
		int length = sequencer.length;
		int celestialID = this.gameObject.GetComponent<celestialProperties>().celestialID;
		
		startingNote = (celestialID+1)*12;
		
		 for (int i = 0; i < length; ++i)
		{
			sequencer.AddNote(startingNote + i *increase, i, i + 1);
		} */
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
