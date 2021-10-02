using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;
    public int scoreLimit = 10;
    public GameObject enemy;

    private void OnTriggerEnter(Collider other)
    {
        print("ontriggerEnter");
        if (other.CompareTag("Collectable"))
        {
            print("collectable");
            score++;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);
        }
        if (score == scoreLimit)
        {
            Debug.Log("killing enemy");
            if (enemy)
            {
                Debug.Log("Got enemy reference");
                enemy.GetComponentInChildren<VFX>().size = 1;
                Invoke("KillEnemy", 12);
            }
        }
    }
    private void KillEnemy()
    {
        if (enemy)
        {
            Destroy(enemy.gameObject);
            scoreText.text = "Congrats you won or sum shit.";
            Debug.Log("You won and stuff");
        }
    }
}