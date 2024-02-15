using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SistemiKapat : MonoBehaviour
{
    public TextMeshProUGUI kapatilacakText;
    public GameObject Sistem1;
    public GameObject Sistem2;
    public GameObject Sistem3;
    public GameObject Sistem4;
    public GameObject Sistem5;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.JoystickButton1))
            {
                this.gameObject.SetActive(false);
                Sistem1.SetActive(false);
                Sistem2.SetActive(false);
                Sistem3.SetActive(false);
                Sistem4.SetActive(false);
                Sistem5.SetActive(false);
                kapatilacakText.text = "";
            }
        }
    }
}
