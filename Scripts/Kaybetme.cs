using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaybetme : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject kaybetmeMenu;

    private void Start()
    {
        Resume();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                if (gameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
        }
    }

    public void Resume()
    {
        kaybetmeMenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    public void Pause()
    {
        kaybetmeMenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
    
}
