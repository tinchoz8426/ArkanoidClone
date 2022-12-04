using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody2D rb2D;
    public float speed;
    public AudioSource brickAudio;

    Vector2 velocity;
    Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
        ResetBall();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DeathZone"))
        {
            
            FindObjectOfType<GameManager>().LostLife();

        }

        if (collision.gameObject.CompareTag("Brick"))
        {
            brickAudio.Play();
        }
    }

    public void ResetBall()
    {
        transform.position = startPosition;
        rb2D.velocity= Vector2.zero;

        velocity.x = Random.Range(-1f, 1f);
        velocity.y = 1;

        rb2D.AddForce(velocity * speed);
    }

}
