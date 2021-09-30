using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;


    private void OnTriggerEnter(Collider other)
    {
        print("ontriggerEnter");
        if (other.CompareTag("Collectable"))
        {
            print("collectable");
            score++;
            scoreText.text = score.ToString();
        }
    }
}