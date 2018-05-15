using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

	public string sceneToLoad;
	public int secondsToWait;

	// Use this for initialization
	void Start () {
		Invoke("OpenNextScene", secondsToWait);
	}
	
	void OpenNextScene() {
		SceneManager.LoadScene(sceneToLoad);
	}
}
