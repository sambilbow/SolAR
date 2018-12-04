using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class celestialDialogueInstantiator : MonoBehaviour {

	// Define prefab to instantiate
	public GameObject celestialDialogue;
	public GameObject systemNameCreate;
	public GameObject parent;
	public Slider slider;
	public GameObject createCelestials;
	public GameObject celestialManager;
	public GameObject systemTitle;

	// Use this for instantiation
	public void makeDialogue (int sliderValue) 
	{
		// For loop that instantiates x amount of dialogues where x = argument.
		for(int i = 0; i < sliderValue; i++)
		{	
			
			var instantiatedDialogue = Instantiate(celestialDialogue,transform.position, Quaternion.identity);
			instantiatedDialogue.transform.SetParent(parent.gameObject.transform, false);
			instantiatedDialogue.SetActive(false);
			instantiatedDialogue.name = "celestialDialogue"+i.ToString();	
			instantiatedDialogue.GetComponent<dialogueID>().ID = i;

			if (i == 0)
			{
				instantiatedDialogue.SetActive(true);
			}		
		}
	}

	public void setActive(int indexToTurnOn)
	{
		// Turn on next dialogue
		if(indexToTurnOn != slider.value)
		{
			GameObject.Find("createDialogue").gameObject.transform.GetChild(indexToTurnOn).gameObject.transform.localScale = new Vector3(0,0,0);
			GameObject.Find("createDialogue").gameObject.transform.GetChild(1+indexToTurnOn).gameObject.SetActive(true);
		}
		
		// When the last next button is pressed.
		if (indexToTurnOn == slider.value)
		{
			
			// Set active createCelestials GUI panel
			parent.gameObject.transform.localScale = new Vector3(0,0,0);
			createCelestials.SetActive(true);
			systemTitle.gameObject.GetComponent<Text>().text = systemNameCreate.GetComponent<Text>().text;
			
			celestialManager.gameObject.GetComponent<celestialObjectInstantiatorCreator>().generate();
			
			
			
			


		}

		
	}


}
