using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    private float speed, jumpforce;
    public bool isGrounded;
    private Rigidbody playerRb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        speed = .02f;
        jumpforce = 7.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
       float horizontalInput = Input.GetAxis("Horizontal");
       float verticalInput = Input.GetAxis("Vertical");

       Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput);

       transform.position += moveDirection * speed;

       if (Input.GetKey(KeyCode.Space) && isGrounded == true)
       {
           playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
           isGrounded = false;
       }

       

    }

    private void OnCollisionEnter(Collision collision) {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.layer == 7)
        {
            Debug.Log("End");
        }
            
    }
}
