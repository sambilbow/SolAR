using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextSetAmount : MonoBehaviour {

	public Slider slider;
	public GameObject dialogueManager;
	
	
	// Use this for initialization
	public void nextButtonDialogue (bool onOff) {

		if(onOff == true)
		{
			dialogueManager.GetComponent<celestialDialogueInstantiator>().makeDialogue(Mathf.RoundToInt(slider.value));
			
		}
	}

	
}
