using UnityEngine;

public class Teleport : MonoBehaviour
{
    float timer = 0f;
    float waitTime = 3f;

    float randomX;
    float randomY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime;
        if (timer >= waitTime)
        {
            Vector2 newPosition = new Vector2(Random.Range(0, Screen.height), Random.Range(0, Screen.width));

            transform.position = newPosition;
        }
;
    }
}
