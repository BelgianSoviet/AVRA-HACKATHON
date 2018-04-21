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
    public class TapForIdle : MonoBehaviour, IInputClickHandler
    {

        public void OnInputClicked(InputClickedEventData eventData)
        {
            InputManager.Instance.RemoveGlobalListener(gameObject);
            SceneManager.LoadScene("Listing");
            eventData.Use(); // Mark the event as used, so it doesn't fall through to other handlers.
        }
    }
}
