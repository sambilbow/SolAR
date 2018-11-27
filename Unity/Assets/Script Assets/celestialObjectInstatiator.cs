using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class celestialObjectInstatiator : MonoBehaviour {

	public GameObject celestialObject;
	public int amountOfCelestials;
	string[] celestialNames = new string[]{"Amalthea","Himalia","Elara","Pasiphae","Sinope","Lysithea","Carme","Ananke","Leda","Thebe","Adrastea","Metis","Callirrhoe","Themisto","Megaclite","Taygete","Chaldene","Harpalyke","Kalyke","Iocaste","Erinome","Isonoe","Praxidike","Autonoe","Thyone","Hermippe","Aitne","Eurydome","Euanthe","Euporie","Orthosie","Sponde","Kale","Pasithee","Hegemone","Mneme","Aoede","Thelxinoe","Arche","Kallichore","Helike","Carpo","Eukelade","Cyllene","Kore","Janus","Epimetheus","Helene","Telesto","Calypso","Atlas","Prometheus","Pandora","Pan","Ymir","Paaliaq","Tarvos","Ijiraq","Suttungr","Kiviuq","Mundilfari","Albiorix","Skathi","Erriapus","Siarnaq","Thrymr","Narvi","Methone","Pallene","Polydeuces","Daphnis","Aegir","Bebhionn","Bergelmir","Bestla","Farbauti","Fenrir","Fornjot","Hati","Hyrrokkin","Kari","Loge","Skoll","Surtur","Anthe","Jarnsaxa","Greip","Tarqeq"};
	string[] systemNameIDs = new string[]{"Alpha","Beta","Gamma","Delta","Epsilon","Zeta","Eta","Theta","Iota","Kappa","Lambda","Mu","Nu","Xi","Omicron","Pi","Rho","Sigma","Tau","Upsilon","Phi","Chi","Psi","Omega"};
	
	
	// Use this for initialization
	public void makeCelestial (int amountOfCelestials) 
	{
		for(int i = 0; i < amountOfCelestials; i++)
		{	
			var instantiatedCelestial = Instantiate(celestialObject, new Vector3(0,0,0),Quaternion.identity);
			var celProps = instantiatedCelestial.GetComponent<celestialProperties>();
			
			celProps.celestialName = celestialNames[Random.Range(0,87)];
			celProps.celestialBodyDistance = 0f;
			celProps.celestialOrbitFrequency = 0f;
			celProps.celestialRotationalFrequency = 0f;
			celProps.celestialBodyDiameter = 0f;
			celProps.celestialBodyTemperature = 0f;
			celProps.celestialOrbitAxis = new Vector3(0,0,0);
		}
	}
	
	void Start() 
	{
		var systemName = GameObject.Find("System Title").gameObject.GetComponent<Text>().text = systemNameIDs[Random.Range(0,23)]+ "    " + Random.Range(3000,7000);
		makeCelestial(amountOfCelestials);	
	}

	// Update is called once per frame
	void Update () 
	{
		
	}
}
