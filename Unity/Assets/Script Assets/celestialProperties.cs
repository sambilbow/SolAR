using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class celestialProperties : MonoBehaviour {

	// Define public variables and axis of spin.
	
	public string celestialName = "defaultName";
	public int celestialID = 0;
	public float celestialBodyDistance = 0f;
	public float celestialOrbitFrequency = 1.0f;
	public float celestialRotationalFrequency = 1.0f;
	public float celestialInitOrbitFrequency = 1.0f;
	public float celestialInitRotationalFrequency = 1.0f;
	public float celestialBodyDiameter = 0f;
	public float celestialBodyTemperature = 0f;
	public Vector3 celestialOrbitAxis  = new Vector3(0,1,0);
	public GameObject celestialStrip;
	
	//public GameObject locator;

	
	

	// Use this for initialization
	void Start() {
				
		// Set position
		transform.position = new Vector3(0,0,celestialBodyDistance);

		// Set scale
		transform.localScale = new Vector3(celestialBodyDiameter,celestialBodyDiameter,celestialBodyDiameter);
		
		// Translate Vector2 for orbit circle
		Vector2 randomPositionOnCircle = RandomOnUnitCircle2(transform.position.z);
		float posX = randomPositionOnCircle.x;
		float posZ = randomPositionOnCircle.y;
		
		// Place gameObject at random point on circle with y=0
		this.gameObject.transform.position = new Vector3 (posX,0,posZ);

		// Set channel on AudioHelm components

		var controller = this.gameObject.GetComponent<AudioHelm.HelmController>();
		var sequencer = this.gameObject.GetComponent<AudioHelm.HelmSequencer>();

		controller.channel = celestialID;
		
		if (sequencer != null) 
		{
			sequencer.channel = celestialID;
		}

		// Set 3D sound settings for celestialObject
		this.gameObject.GetComponent<AudioSource>().maxDistance = celestialBodyDistance+0.1f;

		makeGUI();
	}
	






	// Update is called once per frame
	void Update () 
	{
		// Orbit attached object around parent Y axis at defined cycles per second
		this.transform.RotateAround(Vector3.zero,celestialOrbitAxis,((celestialOrbitFrequency*(Time.deltaTime/31536000)*360)));
		// Rotate attached object around its own Y axis at defined cycles per second
		this.transform.Rotate(Vector3.up*(celestialRotationalFrequency*(Time.deltaTime/86400))*360, Space.World);
	}






	// Create UI strip for celestialObject and set name as celestialName. celestialSprite is randomised.
	void makeGUI ()
	{
		// Define array of sprites from specified folder.
		Sprite[] celestialSpriteArray = Resources.LoadAll<Sprite>("celestialSprites");
		// Define transform of celestial bank
		
		Transform celestialBankTransform =  Resources.FindObjectsOfTypeAll<GameObject>().FirstOrDefault(g=>g.CompareTag("bank")).gameObject.transform;
			
			
			
			// Instantiate celestialStrip prefab
			var instantiatedGUI = Instantiate(celestialStrip, new Vector3 (0,0,0), Quaternion.identity);
			
			
			// Set the instantiated prefab as a child of the celestial bank previously defined.
			instantiatedGUI.transform.SetParent(celestialBankTransform);
			// Set name of insantiated celestialStrip
			instantiatedGUI.name = "celestialStrip" + celestialID;
			// Set celestialStrip text
			instantiatedGUI.transform.Find("celestialName").gameObject.GetComponent<Text>().text = celestialName;
			// Set celestialSprite to random image.
			instantiatedGUI.transform.Find("celestialSprite").gameObject.GetComponent<Image>().sprite = celestialSpriteArray[Random.Range(0,8)]; 

			// Find mute toggle in celestialStrip
			instantiatedGUI.GetComponentInChildren<Toggle>().onValueChanged.AddListener((value) =>
			{
				myListener(value);
			});

			// Find locate button in celestialStrip
			instantiatedGUI.GetComponentInChildren<Button>().onClick.AddListener(buttonAction);
		
	}







	// Function that plays locator sound effect on start
	public void buttonAction()
	{
		this.gameObject.transform.GetChild(0).GetComponent<AudioSource>().Play();
	}








	// Function that listens to the value of the mute button and toggles AudioSource mute.
	void myListener (bool value)
	{
		// If button pressed i.e. value = 1, then mute gameobject audiosource
		if(value)
		{
			this.gameObject.GetComponent<AudioSource>().mute = true;
		}

		else
		{
			this.gameObject.GetComponent<AudioSource>().mute = false;
		}
	}

	void makeMixer ()
	{
		
	}






	// Function that makes a random Vector2 transform on the circumference of the given orbitRadius.
	public static Vector2 RandomOnUnitCircle2(float celestialBodyDistanceAU)
  	{
		Vector2 randomPointOnCircle = Random.insideUnitCircle;
		randomPointOnCircle.Normalize();
		randomPointOnCircle *= celestialBodyDistanceAU;
		return randomPointOnCircle;
  	}
}
