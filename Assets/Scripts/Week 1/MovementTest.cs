using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public Vector3 startingPosition;
    public Vector3 moveDirection;
    public float speed;

    // Start is called when this object first exists in the scene and the game is loaded.
    void Start()
    {
        Debug.Log("Hello World!");

        //this in reference to the object THIS script is on, get reference to its TRANSFORM component and get reference to the tranform's POSITION
        //and SET it (=) to Vector3.zero (which means (0, 0, 0)).
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("WHEEEEEEEEEEE");

        //moveDirection is currently (1, 0, 1) 
        this.transform.position += moveDirection * speed * Time.deltaTime; //Multiplying by Time.deltaTime means "per second" than per frame.
    }
}
