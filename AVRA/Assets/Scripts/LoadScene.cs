using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    string startScene = "Start";
    string workingScene = "Working";
	// Use this for initialization
	void Start () {
        SceneManager.LoadScene(startScene);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
