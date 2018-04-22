using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TapForListing : MonoBehaviour, IInputClickHandler {

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    private Vector3 but1;
    private Vector3 but2;
    private Vector3 but3;
    private Vector3 but4;
    private Vector3 but5;

    private Button itemSelected;

    

    public void OnInputClicked(InputClickedEventData eventData)
    {
        try{
            GameObject gameObjectT;
            if((gameObjectT = eventData.selectedObject.gameObject).tag == "TaskButton") 
            {
                this.resetButtons();
                this.itemSelected = gameObjectT.GetComponentInParent<Button>();
                gameObjectT.GetComponentInParent<Button>().transform.localPosition += new Vector3(0,0,-20);
                return;
            }
            if((gameObjectT = eventData.selectedObject.gameObject).tag == "MenuButton"){
                switch(gameObjectT.GetComponent<Text>().text){
                    case "Delete":
                        //Not implemented
                        break;
                    case "Modify":
                        SceneManager.LoadScene("ModifyTask");
                        break;
                    case "Add":
                        SceneManager.LoadScene("AddTask");
                        break;
                    case "Back":
                        SceneManager.LoadScene("Idle");
                        break;
                }
                return;
            }
        } catch{

        }
        
    }

    void resetButtons()
    {
        this.button1.transform.localPosition = this.but1;
        this.button2.transform.localPosition = this.but2;
        this.button3.transform.localPosition = this.but3;
        this.button4.transform.localPosition = this.but4;
        this.button5.transform.localPosition = this.but5;
    }

    // Use this for initialization
    void Start () {
		this.but1 = button1.transform.localPosition;
        this.but2 = button2.transform.localPosition;
        this.but3 = button3.transform.localPosition;
        this.but4 = button4.transform.localPosition;
        this.but5 = button5.transform.localPosition;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
