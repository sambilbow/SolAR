using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneOnClick : MonoBehaviour {

	// Function that loads scene by defined index on load.
	public void loadByIndex (int sceneIndex)
	{
		SceneManager.LoadScene(sceneIndex);
	}

}
