using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        GenerateEnd();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateEnd()
    {
        int endHieght = Random.Range(20,25);
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + endHieght, player.transform.position.z);

    }
}
