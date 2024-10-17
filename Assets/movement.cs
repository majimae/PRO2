using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;

    Animator anim; 


    public float upForce = 100;
    public float speed = 1500;
    public float runSpeed = 2500;

    public bool isGrounded = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity = new Vector3(Input.GetAxis("Horizontal") * runSpeed * Time.deltaTime, rb.velocity.y, 0);
            }
            else
            {
                rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, rb.velocity.y, 0);
            }

            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                rb.AddForce(Vector3.up * upForce);
                isGrounded = false;
            }

        }

        private void OnCollisionEnter(Collision collision)
        {
            isGrounded = true;
        }
    
}

