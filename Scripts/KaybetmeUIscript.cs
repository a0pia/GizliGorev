using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class KaybetmeUIscript : MonoBehaviour
{
    public GameObject targetButton;

    private void OnEnable()
    {
        if (targetButton != null)
        {
            EventSystem.current.SetSelectedGameObject(targetButton);

            Button buttonComponent = targetButton.GetComponent<Button>();
            if (buttonComponent != null)
            {
                buttonComponent.interactable = true;
            }
        }
    }

}
