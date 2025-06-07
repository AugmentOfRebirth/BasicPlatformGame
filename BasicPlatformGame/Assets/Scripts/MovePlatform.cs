using UnityEngine;

public class NewPlatform : MonoBehaviour
{
    public float movementSpeed;
    //distance the platform can move
    public float offset;
    //where the platform is placed at the beggining of the game
    private float startPosX;
    //used to determine if the platform should move to the right or to the left
    private bool moveRight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveRight = true;
        startPosX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        movePlatform();
    }

    private void movePlatform()
    {
        if(moveRight)
        {
            //this needs to be multiplied by time.deltatime so that we are moving
            //the object based off time and not framerate
            //we do not need to do this with moving the player because
            //velocity is already in a time metric
            transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
        }

        //get x position of player: transform.position.x
        if(transform.position.x >= startPosX)
        {
            moveRight = false;
        }
        else if (transform.position.x <= startPosX - offset)
        {
            moveRight = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.transform.SetParent(gameObject.transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
