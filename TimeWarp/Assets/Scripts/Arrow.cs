using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;
    public GameObject endPoint;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameManager.playGame)
        {
            transform.position = Vector2.MoveTowards(transform.position, endPoint.transform.position, speed * Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        if (gameManager.isFast)
        {
            speed = speed * 2;
        }
        else
        {
            speed = speed / 2;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0f;
    }
}
