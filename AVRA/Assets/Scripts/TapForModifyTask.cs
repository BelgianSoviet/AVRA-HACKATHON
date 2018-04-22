using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.Buttons;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TapForModifyTask : MonoBehaviour,IInputClickHandler{

	public Canvas Canvas;
	public TouchScreenKeyboard keyboard;
	public static string keyboardText = "";

    public void OnInputClicked(InputClickedEventData eventData)
    {
        try{
            GameObject gameObjectT;
            if((gameObjectT = eventData.selectedObject.gameObject).tag == "MenuButton"){
                switch(gameObjectT.GetComponent<Text>().text){
                    case "Cancel":
                        SceneManager.LoadScene("Listing");
                        break;
                    case "Confirm":
						//TODO
                        SceneManager.LoadScene("Listing");
                        break;
                }
                return;
            }
			if((gameObjectT = eventData.selectedObject.gameObject).tag == "InputKeyboard"){
				keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, false, false);
			}
        } catch{

        }
    }

    // Use this for initialization
    void Start () {
		FocusManager.AssertIsInitialized();
		keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, false, false);
		if(Canvas.isRootCanvas && Canvas.renderMode == RenderMode.WorldSpace){
			Canvas.worldCamera = FocusManager.Instance.UIRaycastCamera;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (TouchScreenKeyboard.visible == false && keyboard != null)
		{
       		if (keyboard.done == true)
       		{
           		keyboardText = keyboard.text;
           		keyboard = null;
       		}
		}
	}
}