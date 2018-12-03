using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logSlider : MonoBehaviour {

	public float midValue;
	public float maxValue;
	public float newValue;
		
	private float ExpScale(float inputValue, float midValue, float maxValue)
	{
		float returnValue = 0;
		// returnValue = A + B * Math.Exp(C * inputValue);
		float M = maxValue / midValue;
		float C = Mathf.Log(Mathf.Pow(M - 1, 2));
		float B = maxValue / (Mathf.Exp(C) - 1);
		float A = -1 * B;
		returnValue = A + B * Mathf.Exp(C * inputValue);
		return returnValue;
	}

	private void Update() 
	{
		ExpScale(this.gameObject.GetComponent<Slider>().value,midValue,maxValue);	
		newValue = ExpScale(this.gameObject.GetComponent<Slider>().value,midValue,maxValue);	
	}
}
