using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BetaVersionDelay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(this.WaitForSomeSeconds());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator WaitForSomeSeconds()
	{
		yield return new WaitForSeconds(10);
		SceneManager.LoadScene("AddTask");
	}
}
