using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleEntry : MonoBehaviour {

	[SerializeField]
	public Text task1;
	[SerializeField]
	public Text date1;
	[SerializeField]
	public Text task2;
	[SerializeField]
	public Text date2;
	[SerializeField]
	public Text task3;
	[SerializeField]
	public Text date3;
	[SerializeField]
	public Text task4;
	[SerializeField]
	public Text date4;
	[SerializeField]
	public Text task5;
	[SerializeField]
	public Text date5;
	// Use this for initialization
	void Start () {
		task1.text = "Battle of Codes";
		date1.text = "23 / 05 / 2018";
		task2.text = "Finish project";
		date2.text = "28 / 05 / 2018";
		task3.text = "Work";
		date3.text = "05 / 06 / 2018";
		task4.text = "Exams";
		date4.text = "28 / 06 / 2018";
		task5.text = "Summer vacations";
		date5.text = "15 / 08 / 2018";
		}
	
	// Update is called once per frame
	void Update () {
		
	}
}
