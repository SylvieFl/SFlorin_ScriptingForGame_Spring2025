using TMPro;
using UnityEngine;

public class TimerBobomb : MonoBehaviour
{
    public float timerDuration = 30f;

    public TextMeshProUGUI timerText;

    public BobombManager bobombManager;

    public bool stopCounter = false;

    // Update is called once per frame
    void Update()
    {
        if (timerDuration >= 0f)
        {
            timerDuration -= Time.deltaTime;
            timerText.text = Mathf.RoundToInt(timerDuration).ToString();
        }

        if (timerDuration <= 0f) 
        { 
            stopCounter = true;
            bobombManager.EndBobombCount();
        }
        
    }
}
