using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb = null;
    [SerializeField] private float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude > speed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, speed);
        }
        
        float moveHori = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");
        Vector3 movement = transform.right * moveHori + transform.forward * moveVert;
        if(movement.magnitude >= 0.1f)
            rb.AddForce(movement * speed);
    }
}
