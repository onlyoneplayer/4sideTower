using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;

    public ScoreController score;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        // Add speed to a bullet
        rb.velocity = transform.right * speed;
        DestroyBullet();
    }

    //Destroy bullet after 2 sec                                 
    private void DestroyBullet()
    {
        Destroy(gameObject, 2);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            ScoreController.singleton.AddScore();       
        }
    }
}
