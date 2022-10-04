using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 100;
    public Transform healthBar;
    private string type = "Fire";
    public Rigidbody2D enemyRb;
    public float dashSpeed;
    public BoxCollider2D visionCollider;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0)
        {
            health = 0;
        }
        else if (health > 100)
        {
            health = 100;
        }
        else
        {
            healthBar.localScale = new Vector3(health * 0.01f, healthBar.localScale.y, healthBar.localScale.z);
        }
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            Dash();
    }
    
    private void Dash()
    {
        if(transform.rotation.y == 0)
        {
            enemyRb.velocity = new Vector2(-dashSpeed, enemyRb.velocity.y);
        }else if(transform.rotation.y == 180)
        {
            enemyRb.velocity = new Vector2(dashSpeed, enemyRb.velocity.y);
        }
    }
}
