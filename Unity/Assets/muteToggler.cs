using UnityEngine;
 
 [RequireComponent(typeof(AudioSource))]
 public class muteToggler : MonoBehaviour
 {
     public void ToggleMute()
     {
         var a = GetComponent<AudioSource>();
         a.mute = !a.mute;
     }
 }