using HoloToolkit.Unity.InputModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Script
{
    public class TapResponder : MonoBehaviour, IInputClickHandler
    {
        public Text displayText;
        public static int Click;

        public void OnInputClicked(InputClickedEventData eventData)
        {
            GameObject gameObject;
            if((gameObject = eventData.selectedObject.gameObject).tag == "Button")
            {
                Debug.Log("OKOK");
                switch (gameObject.GetComponentInChildren<Text>().text)
                {
                    case "Button1":
                        Click++;
                        displayText.text = "Click " + Click;
                        break;
                    case "Button2":
                        System.Random random = new System.Random();
                        String[] test = new string[] { "Test1", "Test2", "Test3" };
                        gameObject.GetComponentInChildren<Text>().text = test[random.Next(0, 2)];
                        SceneManager.LoadScene("Test");
                        break;
                }
            }
            eventData.Use(); // Mark the event as used, so it doesn't fall through to other handlers.
        }
    }
}
