using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.Buttons;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using HoloToolkit.UI.Keyboard;
using System;

public class addData
{
	public string description;
	public string task;
	public string day;
	public string month;
	public string year;
}

public class TapForAddTask : MonoBehaviour,IInputClickHandler{

	public Canvas Canvas;
	public Keyboard keyboard;
	private string nameObject;
	public InputField day;
	public InputField month;
	public InputField year;
	public InputField description;
	public InputField task;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        try{
            GameObject gameObjectT;
            if((gameObjectT = eventData.selectedObject.gameObject).tag == "MenuButton"){
                switch(gameObjectT.GetComponent<Text>().text){
                    case "Cancel":
                        SceneManager.LoadScene("Listing");
                        break;
                    case "Create":
						//TODO
                        SceneManager.LoadScene("Listing");
						//Keyboard.Instance.PresentKeyboard();
                        break;
                }
                return;
            }
			if((gameObjectT = eventData.selectedObject.gameObject).tag == "InputKeyboard"){
				nameObject = gameObjectT.name;
				Keyboard.Instance.PresentKeyboard();
				//Keyboard.Instance.OnTextSubmitted += Keyboard_Submit;
				Debug.Log(nameObject);

				
			}
        } catch{

        }
    }

    void Start () {
		FocusManager.AssertIsInitialized();
		if(Canvas.isRootCanvas && Canvas.renderMode == RenderMode.WorldSpace){
			Canvas.worldCamera = FocusManager.Instance.UIRaycastCamera;
			keyboard.GetComponentInChildren<Canvas>().worldCamera = FocusManager.Instance.UIRaycastCamera;
		}
		Keyboard.Instance.OnTextSubmitted += Keyboard_Submit;
	}
	void Keyboard_Submit(object sender,EventArgs e)
	{
		addData myTask = new addData();
		if(sender is Keyboard) 
		{
			Debug.Log("Entry IF 1");
			Keyboard kb = (Keyboard)sender;
			//CurrentObject.GetComponent<Text>().text = kb.InputField.text;
				//description.placeholder = null;
				//description.text = kb.InputField.text;
			if (nameObject == "descriptionText")
			{
				description.placeholder = null;
				description.text = kb.InputField.text;
				Debug.Log(kb.InputField.text);
				Debug.Log(description.text);
				myTask.description = description.text;
			}
			if (nameObject == "taskText")
			{
				task.placeholder = null;
				task.text = kb.InputField.text; 
				myTask.task = task.text;
			}
			if (nameObject == "dayText")
			{
				day.placeholder = null;
				day.text = kb.InputField.text;
				myTask.day = day.text;
			}
			if (nameObject == "monthText")
			{
				month.placeholder = null;
				month.text = kb.InputField.text;
				myTask.month = month.text;
			}
			if (nameObject == "yearText")
			{
				year.placeholder = null;
				year.text = kb.InputField.text;
				myTask.year = year.text;
			}
		}		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Keyboard.Instance.OnTextSubmitted += Keyboard_Submit;
	}
	// string TextToBox()
	// {
		
	// }
}
