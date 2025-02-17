using UnityEngine;

public class TimerCountingDown : MonoBehaviour
{
    public float timerStartingNumber = 5f;
    public float defaultTime = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerStartingNumber = defaultTime;
    }

    // Update is called once per frame
    void Update()
    {
        timerStartingNumber -= Time.deltaTime;

        if (timerStartingNumber <= 0f)
        {
            Debug.Log("Timer has reached 0.");
            timerStartingNumber = defaultTime;
        }
    }
}
