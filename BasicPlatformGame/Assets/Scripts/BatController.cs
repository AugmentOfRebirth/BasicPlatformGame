using UnityEngine;

public class Bat : MonoBehaviour
{
    //make the bat move towards the player
    private GameObject player;
    private Vector2 playerLocation;
    public float speed;
    public float bounceForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerLocation = player.transform.position;
        //speed *= Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, playerLocation, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounceForce);
        }    
    }
}
