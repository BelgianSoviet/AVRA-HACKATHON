using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimations : MonoBehaviour {

    public GameObject startObj;
	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        PlayAnim(startObj);
	}
    void PlayAnim(GameObject startObj)
    {
        startObj.GetComponent<Animation>().Play();
    }
}
