using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
        speed = .02f;
    }

    // Update is called once per frame
    void Update()
    {
       float horizontalInput = Input.GetAxis("Horizontal");
       float verticalInput = Input.GetAxis("Vertical");

       Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput);

       transform.position += moveDirection * speed;



    }
}
