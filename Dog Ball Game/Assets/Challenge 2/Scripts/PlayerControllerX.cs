using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{

    public GameObject dogPrefab;
    private float timer = 1.0f;
    private float waitTime = 1.0f;

    // Update is called once per frame
    void Update()
    {
        //delay key input
        if (timer < waitTime)
        { }
        //send the dogs
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            spawnDog();
            timer = 0;
        }

        //reset the timer
        timer += Time.deltaTime;
        

    }

    void spawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
