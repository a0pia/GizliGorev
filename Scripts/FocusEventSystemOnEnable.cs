using UnityEngine;
using UnityEngine.EventSystems;

public class FocusEventSystemOnEnable : MonoBehaviour
{
    public GameObject secondPanel; // İkinci panel nesnesi

    void OnEnable()
    {
        // EventSystem nesnesini al
        EventSystem eventSystem = FindObjectOfType<EventSystem>();

        // İkinci panel aktif hale geldiğinde EventSystem'e odaklan
        if (eventSystem != null && secondPanel != null)
        {
            eventSystem.SetSelectedGameObject(null); // Önceki seçili nesneyi temizle
            eventSystem.SetSelectedGameObject(secondPanel);
        }
    }
}
