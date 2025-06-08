using UnityEngine;

public class Bat : MonoBehaviour
{
    //make the bat move towards the player
    public GameObject player;
    private Vector2 playerLocation;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerLocation = player.transform.position;
        //speed *= Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, playerLocation, speed * Time.deltaTime);
    }
}
