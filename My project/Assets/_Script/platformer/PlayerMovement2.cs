using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    private Rigidbody2D _rb;
    private NewInput _newInput;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _newInput = GetComponent<NewInput>();
    }

    void FixedUpdate()
    {
        Move();
    }
    public void Move()
    {
        _rb.velocity = new Vector2(_newInput.inputX * speed, _rb.velocity.y);
    }
}
