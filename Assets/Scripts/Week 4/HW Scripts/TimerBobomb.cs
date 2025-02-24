using TMPro;
using UnityEngine;

public class TimerBobomb : MonoBehaviour
{
    public float timerDuration = 30f;

    public TextMeshProUGUI timerText;

    public RandomSpawnBobomb randomSpawnBobomb;

    public bool stopCounter = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (randomSpawnBobomb.spawnCount == randomSpawnBobomb.randSpawnAmount)
        {
            if (timerDuration >= 0f)
            {
                timerDuration -= Time.deltaTime;
                timerText.text = Mathf.RoundToInt(timerDuration).ToString();
            }
        }
        
        if (timerDuration <= 0f) 
        { 
            stopCounter = true;
        }
        
    }
}
