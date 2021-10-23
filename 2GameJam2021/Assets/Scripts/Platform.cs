using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float wallSpeed;
    public bool activated;
    private Rigidbody wallRb;
    public bool frozen;
    
    // Start is called before the first frame update
    void Start()
    {   
        wallRb = GetComponent<Rigidbody>();
        wallSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (activated == true)
        {
           transform.Translate(Vector3.right * Time.deltaTime * wallSpeed);
        }
        
    }

    private void OnCollisionEnter(Collision collision) {
       
        if (collision.gameObject.CompareTag("Player"))
        {
            
            activated = false;
            StartCoroutine("PlatformDestroy");
        } 

        if (collision.gameObject.layer == 6)

        {
           // Debug.Log("BRUH");
            Destroy(gameObject);
        }

       
    }

    IEnumerator PlatformDestroy()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
