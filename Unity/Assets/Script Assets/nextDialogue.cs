using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextDialogue : MonoBehaviour {

		public GameObject parent;

	public void OnClick()
	{
		GameObject.Find("dialogueManager").gameObject.GetComponent<celestialDialogueInstantiator>().setActive(parent.GetComponent<dialogueProperties>().ID+1);

	}
	
}
