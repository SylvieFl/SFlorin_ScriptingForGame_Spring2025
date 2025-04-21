using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public Vector3 randomDirection;
    public float randX;
    public float randY;
    public int speed = 2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randX = Random.Range(-1f, 1f);
        randY = Random.Range(-1f, 1f);

        randomDirection = new Vector3(randX, randY, 0f);
        randomDirection = randomDirection.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += randomDirection * speed * Time.deltaTime;
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "HorizWall")
        {
            randX = -randX;
            randomDirection = new Vector3(randX, randY, 0f);
            randomDirection = randomDirection.normalized;
        }
        else if (collision.gameObject.tag == "VertWall")
        {
            randY = -randY;
            randomDirection = new Vector3(randX, randY, 0f);
            randomDirection = randomDirection.normalized;
        }
    }
}
