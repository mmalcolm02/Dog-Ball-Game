using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private int fastSpawn = 3;
    private int slowSpawn = 5;

    private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        //first ball is called
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        //each invoke int are generated
        int spawnInterval = Random.Range(fastSpawn, slowSpawn);
        int ballArray = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
       

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballArray], spawnPos, ballPrefabs[ballArray].transform.rotation);

        //after instantiate an invoke is called which triggers invoke loop with random intervals
        Invoke("SpawnRandomBall", spawnInterval);
    }

}
