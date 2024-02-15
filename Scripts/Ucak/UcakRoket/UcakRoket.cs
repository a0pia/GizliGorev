using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UcakRoket : MonoBehaviour
{
  
    public GameObject eskiObj;
    public GameObject yeniObj;
    public GameObject eskiGorev;
    public GameObject yeniGorev;
    public GameObject final;
    public GameObject finalGorev;
    public AudioSource SonSes;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("roket"))
        {
            // Eski objeyi yok et
            if (eskiObj != null)
            {
                eskiObj.SetActive(false);
                eskiGorev.SetActive(false);
            }
            // Yeni objeyi aktif et
            if (yeniObj != null)
            {
                yeniObj.SetActive(true);
                yeniGorev.SetActive(true);
                final.SetActive(true);
                finalGorev.SetActive(true);
                SonSes.Play();
            }
        }
        
    }
}
