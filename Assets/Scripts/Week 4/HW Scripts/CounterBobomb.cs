using TMPro;
using UnityEngine;

public class CounterBobomb : MonoBehaviour
{
    public int counterNum;
    
    public TextMeshProUGUI counterText;

    public TimerBobomb timerBobomb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerBobomb.stopCounter == false)
        {
            if (counterNum > 0)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    counterNum--;
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                counterNum++;
            }

            counterText.text = counterNum.ToString();
        }

    }
}
