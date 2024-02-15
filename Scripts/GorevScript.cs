using UnityEngine;
using TMPro;

public class GorevObject : MonoBehaviour
{
    public TextMeshProUGUI kapatilacakText;
    public TextMeshProUGUI acilacakText;
    public GameObject eskiObj;
    public GameObject yeniObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Eski objeyi yok et
            if (eskiObj != null)
            {
                eskiObj.SetActive(false);
            }

            // Kapatılacak texti gizle
            if (kapatilacakText != null)
            {
                kapatilacakText.gameObject.SetActive(false);
            }

            // Açılacak texti göster
            if (acilacakText != null)
            {
                acilacakText.gameObject.SetActive(true);
            }

            // Yeni objeyi aktif et
            if (yeniObj != null)
            {
                yeniObj.SetActive(true);
            }
        }
    }
}
