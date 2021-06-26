using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int velocity = 2;
    private Rigidbody2D rb;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isClicking = Input.GetMouseButtonDown(0);
        bool isClickingRight = Input.GetMouseButtonDown(1);

        if (isClicking)
        {
            rb.velocity = Vector2.up * velocity;
        }

        if (isClickingRight)
        {
            rb.velocity = Vector2.down * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
