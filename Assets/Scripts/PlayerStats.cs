using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int health = 100;
    public Transform healthBar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(health < 0)
        {
            health = 0;
        }else if(health > 100)
        {
            health = 100;
        }
        else
        {
            healthBar.localScale = new Vector3(health*0.01f, healthBar.localScale.y, healthBar.localScale.z);
        }
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
    }
}
