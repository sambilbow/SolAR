using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generateButton : MonoBehaviour {

	public GameObject celestialManager;
	public GameObject audioManager;
	public Slider amountSlider;
	public GameObject system;
	
	public void generate()
	{
        // Runs script on celestial manager which instances celestials = to the amount of celestials chosen.
		this.gameObject.GetComponent<Button>().onClick.AddListener(()=> celestialManager.GetComponent<celestialObjectInstatiatorForCreate>().generate(Mathf.RoundToInt(amountSlider.value)));

		// Runs script on audiomanager which routes AMGS.
		this.gameObject.GetComponent<Button>().onClick.AddListener(()=> audioManager.GetComponent<audioManagerCreate>().generate(Mathf.RoundToInt(amountSlider.value)));
		
		this.gameObject.GetComponent<Button>().onClick.AddListener(()=> switchActivePanels(true));
	}

	public void switchActivePanels(bool value)
	{
		if(value ==true)
		{
			this.gameObject.transform.parent.gameObject.SetActive(false);
			system.SetActive(true);
		}
	}


}
