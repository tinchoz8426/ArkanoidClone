using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb2D;
    public float moveSpeed;

    float inputValue;

    Vector2 direction;
    Vector2 startPosition;

    private void Start()
    {
        startPosition= transform.position;
    }


    void Update()
    {
        inputValue = Input.GetAxisRaw("Horizontal");
        //Debug.Log(inputValue);


        if(inputValue == 1)
        {
            direction = Vector2.right;

        } else if(inputValue == -1)
        {
            direction = Vector2.left;
        } else
        {
            direction = Vector2.zero;
        }

        rb2D.AddForce(direction * moveSpeed * Time.deltaTime * 100);
    }

    public void ResetPlayer()
    {
        transform.position = startPosition;
        rb2D.velocity= Vector2.zero;
    }

}
