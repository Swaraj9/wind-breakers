using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerControls : MonoBehaviour
{
    private float horizontalInput;
    public float moveSpeed = 10;
    private Rigidbody2D playerRb;
    public float jumpStrength = 5;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        playerRb.velocity = new Vector2(moveSpeed * horizontalInput, playerRb.velocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpStrength);
        }
    }
}
