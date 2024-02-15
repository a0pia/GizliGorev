using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneCircle : MonoBehaviour
{
    private CoinSystem coinSystem; // CoinSystem scriptine erişmek için referans

    private void Start()
    {
        coinSystem = FindObjectOfType<CoinSystem>(); // CoinSystem scriptine referans al
    }

    // Tetikleyici (trigger) collider'a temas ettiğimizde çalışacak fonksiyon
    void OnTriggerEnter(Collider other)
    {
        // Temas edilen collider'ın etiketini kontrol ediyoruz
        if (other.CompareTag("Target"))
        {
            // Eğer temas edilen obje "Target" tag'ine sahipse, o objeyi yok ediyoruz
            Destroy(other.gameObject);

            // CoinSystem scriptindeki IncreaseScore fonksiyonunu çağırarak puanı artır
            if (coinSystem != null)
            {
                coinSystem.IncreaseScore(10); // Her bir hedef nesne yok olunca puanı 10 artır
            }
        }
        if (other.CompareTag("final"))
        {
            SceneManager.LoadScene(4);
        }

    }
}
