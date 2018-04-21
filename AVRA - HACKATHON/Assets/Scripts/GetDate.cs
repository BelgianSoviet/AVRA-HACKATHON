using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetDate : MonoBehaviour
{
    public Text dateDisplay;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        System.DateTime time = System.DateTime.Now;

        dateDisplay.text = time.Day + " / " + time.Month + " / " + time.Year;
    }
}
