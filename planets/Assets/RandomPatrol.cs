using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPatrol : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    Vector2 targetPosition;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = GetRandomPostiton();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        } else {
            targetPosition = GetRandomPostiton();
        }
    }

    Vector2 GetRandomPostiton() {
        float ramdomX = Random.Range(minX,maxX);
        float ramdomY = Random.Range(minY,maxY);
        return new Vector2(ramdomX, ramdomY);
    }
}
