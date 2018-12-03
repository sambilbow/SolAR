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
	public int dialogueID;
	public GameObject slider;
	public GameObject[] celestialObjects;

	// Use this for instantiation
	public void makeDialogue (int sliderValue) 
	{
		// For loop that instantiates x amount of dialogues where x = argument.
		for(int i = 0; i < sliderValue; i++)
		{	
			
			var instantiatedDialogue = Instantiate(celestialDialogue,transform.position, Quaternion.identity);
			instantiatedDialogue.transform.SetParent(GameObject.Find("createDialogue").gameObject.transform, false);
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
		if(indexToTurnOn != slider.GetComponent<Slider>().value)
		{
			GameObject.Find("createDialogue").gameObject.transform.GetChild(indexToTurnOn).gameObject.transform.localScale = new Vector3(0,0,0);
			GameObject.Find("createDialogue").gameObject.transform.GetChild(1+indexToTurnOn).gameObject.SetActive(true);
		}
		
		// When the last next button is pressed.
		else
		{
			
			// Set active createCelestials GUI panel
			Resources.FindObjectsOfTypeAll<GameObject>().FirstOrDefault(g=>g.CompareTag("Finish")).gameObject.SetActive(true);
			GameObject.Find("System Title").gameObject.GetComponent<Text>().text = GameObject.Find("dialogueManager").GetComponent<celestialDialogueInstantiator>().systemNameCreate.GetComponent<Text>().text;
			this.gameObject.GetComponent<nextSetAmount>().nextButtonCelestials(true);
			AudioListener.pause = false;
			setAllInactive(parent.transform, true);	
			
			


		}

		
	}


	 // Sets all inactive if value = true
	public void setAllInactive (Transform transform, bool value)
	{
	 	foreach (Transform child in transform)
			{
				if(value == true)
				{
					child.gameObject.SetActive(!value);
				}
				
	
			}		
	} 
}
