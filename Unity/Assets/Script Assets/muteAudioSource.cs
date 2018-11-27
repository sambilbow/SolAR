using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteAudioSource : MonoBehaviour {

	// Use this for initialization
	public void muter () 
	{
        var audioSource = GetComponent<AudioSource>();
        audioSource.mute = !audioSource.mute;
    }
}
