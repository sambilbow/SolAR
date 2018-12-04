using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generateButton : MonoBehaviour {

	public GameObject dialogueManager;
	public Slider amountSlider;
	
	public void generate()
	{
        // Runs script on dialogue manager which instances dialogues and celestials = to the amount of celestials chosen.
		this.gameObject.GetComponent<Button>().onClick.AddListener(()=> dialogueManager.GetComponent<instanceManager>().makeDialogue(Mathf.RoundToInt(amountSlider.value)));

		
	}



}
