using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class systemName : MonoBehaviour {

	

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Text>().text = GameObject.Find("dialogueManager").GetComponent<celestialDialogueInstantiator>().systemNameCreate.GetComponent<Text>().text;
	}
	
	
}
