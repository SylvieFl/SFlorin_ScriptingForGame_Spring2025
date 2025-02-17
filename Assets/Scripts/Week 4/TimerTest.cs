using UnityEngine;

public class TimerTest : MonoBehaviour
{
    public float timerCountingUp = 0f;
    public float timerMaxDuration = 3f;

    public bool hasFinishedTimer = false;

    public GameObject cube;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //When using Random.Range, when you put f after the numbers in the function, it will return a decimal number between those two numbers. If you do NOT put
        //the f after the number, it will return a whole number fromt the first number to the last, not including the last number.
        timerMaxDuration = Random.Range(1f, 4f);

        Invoke("MoveCubeRight", timerMaxDuration);
    }

    // In this Update, once the timer finishes, it changes a bool called hasFinishedTimer to true, which prevents additional logic from being run
    //for the timer. This is how you can make sure something ONLY happens ONCE based on a timer.
    /*
    void Update()
    {
        if (hasFinishedTimer == false)
        {
            timerCountingUp += Time.deltaTime;
            //Debug.Log(timerCountingUp);
            if (timerCountingUp >= timerMaxDuration)
            {
                hasFinishedTimer = true;
                Debug.Log("Reached end of timer");
            }
        }
        
    }*/

    //In this Update, the timer counts up, but on it reaches the timerMaxDuration, it will move the cube to the right without Time.deltaTime
    // because we want it to move in one motion, not over time. Additionally, we reset the timerCountingUp to 0 so that it will count back
    //up to timerMaxDuration and move the cube once more.
    /*
    void Update()
    {
        timerCountingUp += Time.deltaTime;
        //Debug.Log(timerCountingUp);
        if (timerCountingUp >= timerMaxDuration)
        {
            Debug.Log("Reached end of timer");
            MoveCubeRight();
            timerCountingUp = 0f;
        }

    }*/



    void MoveCubeRight()
    {
        cube.transform.position += Vector3.right;

        if (cube.transform.position.x < 10)
        {
            Invoke("MoveCubeRight", timerMaxDuration); //Calling a function recursively (Calling it in itself)
        }
        
    }
}
