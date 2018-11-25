using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setBPM : MonoBehaviour {

	
	public Slider timeSlider;
	public Slider bpmSlider;

	void Update()
	{
	float oldRange = (1f - 0.0000000316880878140289f);
	float newRange = (120f);
	bpmSlider.value = (((timeSlider.value - 0.0000000316880878140289f) * newRange) / oldRange) + 20f;
	}
}
