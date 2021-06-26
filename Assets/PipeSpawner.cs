using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Prefab GameObject used a pipe
    public GameObject pipe;

    // Time to spawn another pipe
    public float maxTime = 1;
    
    // Controls where the height a given pipe will be spawned
    public float height;

    // Timer to control the spawn time
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            // Clones given pipe to a new object
            GameObject newPipe = Instantiate(pipe);

            // Sets the new pipe position to the Spawner object and gets a random height
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            // Destroys the pipe after X seconds
            Destroy(newPipe, 10);

            // Reset the timer to restart the count
            timer = 0;
        }

        // Updates timer each frame
        timer += Time.deltaTime;
    }
}
