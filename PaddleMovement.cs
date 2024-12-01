using UnityEngine;
using UnityEngine.UIElements;

public class PaddleMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float moveSpeed = 10f;
    public string inputAxis;

    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis(inputAxis) * moveSpeed * Time.deltaTime;
        transform.Translate(0, move, 0);

        Vector3 position = transform.position;
        position.y = Mathf.Clamp(position.y, -4.5f, 4.5f);
        transform.position = position;
    }
}
