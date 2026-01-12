using UnityEngine;

public class Teleport : MonoBehaviour
{
    float randomX;
    float randomY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 newPosition = new Vector2(randomX, randomY);
        randomX = Random.Range(0, Screen.width);
        randomY = Random.Range(0, Screen.height);

        transform.position = newPosition;
    }
}
