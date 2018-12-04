using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextButton : MonoBehaviour {

	public GameObject dialogueManager;
	public Slider amountSlider;
	
	public void nextInstance()
	{

		// Set inactive "createSystem"
		this.gameObject.transform.parent.gameObject.transform.parent.gameObject.SetActive(false);
		
	}

	
}
