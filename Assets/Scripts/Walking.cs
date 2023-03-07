using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Walking : MonoBehaviour
{
    private Vector2 moveInput;
    private Rigidbody2D rb;

    public float moveSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}

