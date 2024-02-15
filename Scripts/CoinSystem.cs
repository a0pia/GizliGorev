using TMPro;
using UnityEngine;

public class CoinSystem : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    public GameObject targetObject; // Hedef obje
    public TextMeshProUGUI FinalText; // Hedef Metin
    private void Start()
    {
        UpdateScoreText();
    }

    // Puanı güncelleyen fonksiyon
    private void UpdateScoreText()
    {
        scoreText.text = "Skor: " + score.ToString();
        CheckScore();
    }

    // Puanı artıran fonksiyon
    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    // Puan 100 olduğunda kontrol eden fonksiyon
    private void CheckScore()
    {
        if (score >= 100)
        {
            ActivateTargetObject();
        }
    }

    // Hedef objeyi aktif hale getiren fonksiyon
    private void ActivateTargetObject()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(true);
            FinalText.text = "Yeni Görev : Gizli Bölgeyi imha et!";
        }
    }
}
