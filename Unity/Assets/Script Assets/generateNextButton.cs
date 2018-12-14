using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generateNextButton : MonoBehaviour {

	public void hide0 (bool value)
	{
		if(value == true)
		{
		this.gameObject.transform.parent.localScale = new Vector3(0,0,0);	
		}
		
	}
}
