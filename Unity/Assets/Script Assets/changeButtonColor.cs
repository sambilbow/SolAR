using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeButtonColor : MonoBehaviour {

	public Button button;

	public void buttonColorChanger (byte r, byte g, byte b)
		{
		button.GetComponent<Image>().color = Color.yellow;
		}
	
}



