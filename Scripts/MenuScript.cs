using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject activateObject;
    public GameObject deactivateObject;
    public GameObject activateObject1;
    public GameObject deactivateObject1;
    public GameObject activateObject2;
    public GameObject deactivateObject2;

    public GameObject activateObject3;
    public GameObject activateObject32;
    public GameObject deactivateObject3;
    public GameObject deactivateObject32;
    public GameObject activateObject4;
    public GameObject activateObject42;
    public GameObject deactivateObject4;
    public GameObject deactivateObject42;

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

   
    public void Anasayfa()
    {
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            if (sceneIndex == 0)
            {
                if (activateObject != null)
                {
                    activateObject.SetActive(true);
                }
                if (deactivateObject != null)
                {
                    deactivateObject.SetActive(false);
                }
            }
            else
            {
                // Sahne index'i 0 değilse
                SceneManager.LoadScene(0); // 0 index'li sahneyi yükle
            }
        }
        
    }
    public void Bolumler()
    {
        if (activateObject1 != null)
        {
            activateObject1.SetActive(true);
        }
        if (deactivateObject1 != null)
        {
            deactivateObject1.SetActive(false);
        }
    }
    public void Ayarlar()
    {
        if (activateObject2 != null)
        {
            activateObject2.SetActive(true);
        }
        if (deactivateObject2 != null)
        {
            deactivateObject2.SetActive(false);
        }
    }
    public void BolumlerAnasayfa()
    {
        if (activateObject3 != null)
        {
            activateObject3.SetActive(true);
        }
        if (activateObject32 != null)
        {
            activateObject32.SetActive(true);
        }
        if (deactivateObject3 != null)
        {
            deactivateObject3.SetActive(false);
        }
        if (deactivateObject32 != null)
        {
            deactivateObject32.SetActive(false);
        }
    }
    public void AyarlarAnasayfa()
    {
        if (activateObject4 != null)
        {
            activateObject4.SetActive(true);
        }
        if (activateObject42 != null)
        {
            activateObject42.SetActive(true);
        }
        if (deactivateObject4 != null)
        {
            deactivateObject4.SetActive(false);
        }
        if (deactivateObject42 != null)
        {
            deactivateObject42.SetActive(false);
        }
    }
    

    public void YeniOyun()
    {
        SceneManager.LoadScene(1);
    }
    public void Bolum02()
    {
        SceneManager.LoadScene(2);
    }
    public void Cikis()
    {
        Application.Quit();

    }
}
