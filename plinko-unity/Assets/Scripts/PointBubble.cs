using UnityEngine;

public class PointBubble : MonoBehaviour
{
    public GameObject bubble;
    public ScoreKeeper scoreKeeper;
    public int points = 1;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        scoreKeeper.AddScore(points);
        Destroy(bubble.gameObject);

    }
}
