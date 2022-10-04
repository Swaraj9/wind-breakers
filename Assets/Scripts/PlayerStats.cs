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
        healthBar = GameObject.FindGameObjectWithTag("HealthBar").transform;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.localScale = new Vector3(health*0.01f, healthBar.localScale.y, healthBar.localScale.z);
    }
}
