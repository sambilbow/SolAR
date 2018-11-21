using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startAnimation : MonoBehaviour {

	float t;
    Vector2 startPosition = new Vector2(-540,960);
    Vector2 endPosition = new Vector2(540,960);
    float timeToReachTarget = 1f;

	// Use this for initialization
    void Start () 
    {
    endPosition = transform.position;	
    }
	
	
    
    
    // Update is called once per frame
	void Update () 
    {	
    t += Time.deltaTime/timeToReachTarget;
    transform.position = Vector2.Lerp(startPosition, endPosition, t);
    }
     
     
    
    
    
    public void SetDestination(Vector2 destination, float time)
    {
        t = 0;
        startPosition = transform.position;
        timeToReachTarget = time;
        endPosition = destination; 
    } 
	


    
}
