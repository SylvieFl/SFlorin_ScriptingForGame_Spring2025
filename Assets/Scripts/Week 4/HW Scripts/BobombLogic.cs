using UnityEngine;

public class BobombLogic : MonoBehaviour
{
    public Vector3 position1;
    public Vector3 position2;

    public float randSpeed;
    public bool doMovement = true;
    public bool position2Set = false;
    public bool firstMoveBobomb = false;

    public float boolTimer;

    public RandomSpawnBobomb randSpawnBobomb;
    public TimerBobomb timerBobomb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randSpawnBobomb = FindAnyObjectByType<RandomSpawnBobomb>();
        timerBobomb = FindAnyObjectByType<TimerBobomb>();
        position1 = transform.position;
        boolTimer = Random.Range(3, 7);
        Invoke("MoveBobomb", Random.Range(1, 9));
    }

    // Update is called once per frame
    void Update()
    {
        if (randSpawnBobomb.spawnCount == randSpawnBobomb.randSpawnAmount && firstMoveBobomb == true && timerBobomb.stopCounter == false) 
        {
            MoveBobomb();
        }
    }

    public void MoveBobomb()
    {
        if (firstMoveBobomb == false) 
        {
            firstMoveBobomb = true;
        }
        

        if (position2Set == false) 
        {
            position2 = new Vector3(Random.Range(randSpawnBobomb.minX, randSpawnBobomb.maxX), 0.32f, Random.Range(randSpawnBobomb.minZ, randSpawnBobomb.maxZ));
            randSpeed = Random.Range(1, 5);
            position2Set = true;
        }
        
        
        Vector3 direction;

        direction = position2 - position1;

        direction = direction.normalized;
        Debug.Log("direction " + direction);

        Debug.Log(Vector3.Distance(position1, position2));

        if (Vector3.Distance(position1, position2) < 0.1f)
        {
            this.transform.position = position2;
            position1 = this.transform.position;
            Debug.Log("set position");
            Position2Bool();
        }
        else
        {
            this.transform.position += direction * randSpeed * Time.deltaTime;
            position1 = this.transform.position;
        }

    }

    public void Position2Bool()
    {
        if (position2Set == true)
        {
            boolTimer -= Time.deltaTime;

            if (boolTimer <= 0)
            {
                position2Set = false;
                boolTimer = Random.Range(4, 10);
            }
        }
    }
}
