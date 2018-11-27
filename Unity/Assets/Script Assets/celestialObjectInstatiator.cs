using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class celestialObjectInstatiator : MonoBehaviour {

	// Define prefab to instantiate
	public GameObject celestialObject;
	// Define int that holds the number of celestials to be instantiated
	public int amountOfCelestials;
	// Define string array with possible celestial names
	string[] celestialNames = new string[]{"Amalthea","Himalia","Elara","Pasiphae","Sinope","Lysithea","Carme","Ananke","Leda","Thebe","Adrastea","Metis","Callirrhoe","Themisto","Megaclite","Taygete","Chaldene","Harpalyke","Kalyke","Iocaste","Erinome","Isonoe","Praxidike","Autonoe","Thyone","Hermippe","Aitne","Eurydome","Euanthe","Euporie","Orthosie","Sponde","Kale","Pasithee","Hegemone","Mneme","Aoede","Thelxinoe","Arche","Kallichore","Helike","Carpo","Eukelade","Cyllene","Kore","Janus","Epimetheus","Helene","Telesto","Calypso","Atlas","Prometheus","Pandora","Pan","Ymir","Paaliaq","Tarvos","Ijiraq","Suttungr","Kiviuq","Mundilfari","Albiorix","Skathi","Erriapus","Siarnaq","Thrymr","Narvi","Methone","Pallene","Polydeuces","Daphnis","Aegir","Bebhionn","Bergelmir","Bestla","Farbauti","Fenrir","Fornjot","Hati","Hyrrokkin","Kari","Loge","Skoll","Surtur","Anthe","Jarnsaxa","Greip","Tarqeq"};
	// Define string array with possible system ID names
	string[] systemNameIDs = new string[]{"Alpha","Beta","Gamma","Delta","Epsilon","Zeta","Eta","Theta","Iota","Kappa","Lambda","Mu","Nu","Xi","Omicron","Pi","Rho","Sigma","Tau","Upsilon","Phi","Chi","Psi","Omega"};
	
	
	// Use this for instantiation
	public void makeCelestial (int amountOfCelestials) 
	{
		// For loop that instantiates x amount of celestials where x = defined int above.
		for(int i = 0; i < amountOfCelestials; i++)
		{	
			// Instantiate celestialObject prefab
			var instantiatedCelestial = Instantiate(celestialObject, new Vector3(0,0,0),Quaternion.identity);
			// Define properties script for ease of code
			var celProps = instantiatedCelestial.GetComponent<celestialProperties>();

			instantiatedCelestial.gameObject.name = ("celestialObject"+i);
			
			// Randomise properties of the instantiated celestialObject prefab
			celProps.celestialName = celestialNames[Random.Range(0,87)];
			celProps.celestialBodyDistance = Random.Range(0.1f,15f);
			celProps.celestialOrbitFrequency = Random.Range(0.1f,180f);
			celProps.celestialRotationalFrequency = Random.Range(0.1f,300f);
			celProps.celestialBodyDiameter = Random.Range(0.00f,1f);
			celProps.celestialBodyTemperature = Random.Range(0f,4000f);
			celProps.celestialOrbitAxis = new Vector3(0,1,0);

			// Store initial values for these two so that scaling doesnt multiply by itself
			celProps.celestialInitOrbitFrequency = celProps.celestialOrbitFrequency;
			celProps.celestialInitRotationalFrequency = celProps.celestialRotationalFrequency;
		}
	}
	
	void Start() 
	{
		GameObject.Find("System Title").gameObject.GetComponent<Text>().text = systemNameIDs[Random.Range(0,23)]+ "  -  " + Random.Range(3000,7000);
		makeCelestial(amountOfCelestials);	
	}

	// Update is called once per frame
	void Update () 
	{
		
	}
}
