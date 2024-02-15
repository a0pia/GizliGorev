using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KaybettinUcak : MonoBehaviour
{
    private void KaybettinTekrar()
    {
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            SceneManager.LoadScene(2);
            Debug.Log("Deneme");
        }
        
    }
}
