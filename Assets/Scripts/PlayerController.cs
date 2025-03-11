using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float acceleration;
    public float deceleration;
    private bool isMoving;
    private Vector2 input;

    public int maxHealth = 20;
    public int currentHealth;
    private Vector2 currentVelocity;

    Rigidbody2D rigidbody;


    // public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentVelocity = Vector2.zero;
        currentHealth = maxHealth;
        Application.targetFrameRate = 60;
        rigidbody = GetComponent<Rigidbody2D>();
        // healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x += h * moveSpeed * Time.deltaTime;
        position.y += v * moveSpeed * Time.deltaTime;
        rigidbody.MovePosition(position);
    }

/*
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    */

    void Die()
    {
        Destroy(gameObject);
    }
}
