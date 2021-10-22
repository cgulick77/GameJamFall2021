using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPlatform : MonoBehaviour
{
    public float wallSpeed;
    public bool activated;
    public GameObject [] platform;
    public GameObject spawnPos;
    public GameObject player;
    public float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("PlatformSpawner");

        transform.RotateAround(player.transform.position, Vector3.up, 20 * Time.deltaTime);
    }

    void PlatformRandom()
    {
       
        
             int randomPlat = Random.Range(0, platform.Length);
            Instantiate(platform[randomPlat], spawnPos.transform.position, spawnPos.transform.rotation);
            
        
    }

    IEnumerator PlatformSpawner ()
    {
        
         if (activated == true)
         {
             PlatformRandom();
             activated = false;
             yield return new WaitForSeconds(spawnRate);
             activated = true;
         }
    }
}
