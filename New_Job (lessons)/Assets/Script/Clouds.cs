using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float speed = 2.0F;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(1 * speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Delete")
        {
            Destroy(this.gameObject);
        }
    }
}
