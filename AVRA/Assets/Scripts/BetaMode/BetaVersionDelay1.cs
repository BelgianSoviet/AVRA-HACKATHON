using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BetaVersionDelay1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(this.WFSS());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator WFSS() //Wait for some secs
	{
		yield return new WaitForSeconds(10);
		SceneManager.LoadScene("Listing");
	}
}
