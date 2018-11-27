using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setBPM : MonoBehaviour {

	
	public Slider timeSlider;
	public float bpmMinimum = 20f;
	public float bpmMaximum = 140f;

	void Update()
	{
	float oldRange = (1f - 0.0000000316880878140289f);
	float newRange = (bpmMaximum-bpmMinimum);
	GetComponent<AudioHelm.AudioHelmClock>().bpm = (((timeSlider.value - 0.0000000316880878140289f) * newRange) / oldRange) + 20f;
	}
}
