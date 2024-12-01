using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float moveSpeed = 10f;
    private Rigidbody2D rb;
    private bool gameOver = false;

    public float leftBound = -20f;
    public float rightBound = 20;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    public void LaunchBall()
    {
        float x = Random.Range(0,2) == 0? -1 : 1;
        float y = Random.Range(-1f, 1f);
        Vector2 direction = new Vector2(x,y).normalized;
        rb.linearVelocity = direction * moveSpeed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftBound || transform.position.x > rightBound)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        if (!gameOver)
        {
            gameOver = true;

            rb.linearVelocity = Vector2.zero;

            Debug.Log("Game Over!");
        }
    }
}
