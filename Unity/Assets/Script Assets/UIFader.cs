﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFader : MonoBehaviour {

	public CanvasGroup uiElement;
	
	void start(){

		FadeOut();
	}

	public void FadeIn()
	{
		StartCoroutine(FadeCanvasGroup(uiElement,uiElement.alpha, 1));	
	}

	public void FadeOut()
	{
		StartCoroutine(FadeCanvasGroup(uiElement,uiElement.alpha, 0));	
	}

	public IEnumerator FadeCanvasGroup(CanvasGroup canvasGroup, float start, float end, float lerpTime = 0.5f){

		float _timeStartedLerping = Time.time;
		float timeSinceStarted = Time.time - +_timeStartedLerping;
		float percentageComplete = timeSinceStarted/ lerpTime;
		while(true)
			{

			timeSinceStarted = Time.time - +_timeStartedLerping;
			percentageComplete = timeSinceStarted / lerpTime;

			float currentValue = Mathf.Lerp(start,end,percentageComplete);
			
			canvasGroup.alpha = currentValue;

			if(percentageComplete >= 1) break;

			yield return new WaitForEndOfFrame();
			}

		print("done");

	}
}


