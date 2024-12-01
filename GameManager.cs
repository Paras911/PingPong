using JetBrains.Annotations;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform ball;
    public Transform paddle1;
    public Transform paddle2;

    public Vector2 initialBallPosition = Vector2.zero;
    public Vector2 initialPaddle1Position = new Vector2(-8, 0);
    public Vector2 initialPaddle2Position = new Vector2(8, 0);

    public void ResetPositions()
    {
        ball.position = initialBallPosition;
        paddle1.position = initialPaddle1Position;
        paddle2.position = initialPaddle2Position;

        ball.GetComponent<BallMovement>().LaunchBall();

    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
