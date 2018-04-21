using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetDateHours : MonoBehaviour
{
    public Text Hours;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        System.DateTime time = System.DateTime.Now;

        Hours.text = time.Hour + " : " + time.Minute + " : " + time.Second;
    }
}
