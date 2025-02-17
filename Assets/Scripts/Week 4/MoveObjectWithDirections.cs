using UnityEngine;

public class MoveObjectWithDirections : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;

    public float speed = 4;

    public bool hasReachedDestination = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    /*
    void Update()
    {
        //This gets the direction every frame, updating when point 1 moves.
        //This causes the point1 object to steadily creep towards point2. slowing down as it approaches because the direction is slowly getting smaller.
        Vector3 direction;

        direction = point2.transform.position - point1.transform.position;
        Debug.Log(direction);

        point1.transform.position += direction * Time.deltaTime; 
    }*/
    /*
    private void Update()
    {
        //This version normalizes the diection of the movement vector, so it travels steadily towards point2 multiplied by a speed variable,
        //so it can speed up. Unfortunately, it jitters as it reaches the end because it always moves past the exact position of point2.
        Vector3 direction;
        
        direction = point2.transform.position - point1.transform.position;

        direction = direction.normalized;
        Debug.Log(direction);
        
        point1.transform.position += direction * speed * Time.deltaTime;
    }*/
    /*
    private void Update()
    {
        //In this version of Update, we check the distance between point1 and point2. If it is close enough (within 0.1 unit), it teleports point 1 to point2
        //which is visually not noticeable. And it will stop trying to move point1 towards point2 because it is already on top of it and therefore within
        //distance
        Vector3 direction;

        direction = point2.transform.position - point1.transform.position;

        direction = direction.normalized;
        Debug.Log(direction);

        Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));

        if (Vector3.Distance(point1.transform.position, point2.transform.position) < 0.1f)
        {
            point1.transform.position = point2.transform.position;
        }
        else
        {
            point1.transform.position += direction * speed * Time.deltaTime;
        }
    }*/

    private void Update()
    {
        //This version of Update will only run if point 1 hasn't reached its destination. Now, it will stop running all the code in Update once it has reached
        // its destination. because we have this hasReachedDestination bool variable that 
        if (hasReachedDestination == false)
        {
            Vector3 direction;

            direction = point2.transform.position - point1.transform.position;

            direction = direction.normalized;
            Debug.Log(direction);

            Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));

            if (Vector3.Distance(point1.transform.position, point2.transform.position) < 0.1f)
            {
                point1.transform.position = point2.transform.position;
                hasReachedDestination = true;
            }
            else
            {
                point1.transform.position += direction * speed * Time.deltaTime;
            }
        }
        
    }
}
