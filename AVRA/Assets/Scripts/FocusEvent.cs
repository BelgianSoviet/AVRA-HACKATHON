using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;
using UnityEngine.UI;

public class FocusEvent : MonoBehaviour, IFocusable {


    public void OnFocusEnter()
    {
        gameObject.GetComponentInChildren<Text>().color = new Color(0, 71, 188, 255);
    }

    public void OnFocusExit()
    {
        gameObject.GetComponentInChildren<Text>().color = new Color(255, 255, 255, 255);
	} //MARCHE PAS POUR LE MOMENT

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
