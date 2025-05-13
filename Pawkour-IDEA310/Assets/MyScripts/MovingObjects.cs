using UnityEngine;

public class MovingObjects : MonoBehaviour
{
    public float speed = 2.0f; // Speed of movement
    public float distance = 5.0f; // Distance to move back and forth

    private Vector3 startPosition;
    private bool movingForward = true;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movement = speed * Time.deltaTime;
        if (movingForward)
        {
            transform.Translate(Vector3.right * movement);
            if (Vector3.Distance(startPosition, transform.position) >= distance)
            {
                movingForward = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * movement);
            if (Vector3.Distance(startPosition, transform.position) <= 0.1f)
            {
                movingForward = true;
            }
        }
    }
}
