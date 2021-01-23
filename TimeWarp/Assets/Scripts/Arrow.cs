using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;
    public GameObject endPoint;
    public GameManager gameManager;
    public SpriteRenderer sprite;

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

        if (speed < 5)
        {

            sprite.color = Color.blue;

        }
        else if (speed > 5)
        {

            sprite.color = Color.red;

        }
        else {

            sprite.color = Color.white;

        }
    }

    private void OnMouseDown()
    {
        if (gameManager.isFast)
        {
            speed = 10f;
        }
        else
        {
            speed = 2.5f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0f;
    }
}
