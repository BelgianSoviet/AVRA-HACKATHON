using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BetaVersionDelay4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(WFSS());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		IEnumerator WFSS()
	{
		yield return new WaitForSeconds(10);
		SceneManager.LoadScene("Start");
	}
}
