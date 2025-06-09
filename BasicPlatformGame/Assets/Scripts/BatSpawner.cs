using UnityEngine;

public class BatSpawner : MonoBehaviour
{
    public GameObject spawnedObject;
    //timer to delay the spawn
    private float time;
    //timer delay
    public float delay;
    //keep track of an array of gameobjects
    //these gameobjects will be the position that a bat can spawn
    public GameObject[] spawnLocations;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //add time to time
        //this will see how much time has passed since the last frame
        time += Time.deltaTime;

        //i only want to spawn a new bat if there was a specified amount
        //of time between the last time i spawned an object
        if(time >= delay)
        {
            spawnBat();
            time = 0f;
        }

    }

    private void spawnBat()
    {
        //max number on Random.Range is exlusive (up to not including)
        int spawnNum = Random.Range(0, spawnLocations.Length);
        //determine which object from the array to spawn
        //based of random spawnNum
        GameObject spawnLocation = spawnLocations[spawnNum];
        //spawn the bat
        Instantiate(spawnedObject);
        spawnedObject.transform.position = new Vector2(spawnLocation.transform.position.x, spawnLocation.transform.position.y);
    }
}
