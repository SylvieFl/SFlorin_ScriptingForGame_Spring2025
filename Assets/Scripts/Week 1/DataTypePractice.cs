using UnityEngine;

public class DataTypePractice : MonoBehaviour
{
    public int number;
    public float yoshi = 4.8f;
    char bee = 'B';
    string fullSentence;
    string intro = "Hello World";
    string outro = "See ya later.";
    public string chestName;
    float total;
    public float mario;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        number = 56;

        number = (number + 5) * 2 / (3 - 7);

        Debug.Log(number);

        Debug.Log(yoshi);

        //subtract 2 from the current value of yoshi.
        yoshi = yoshi - 2;

        //subtract 2 from the current value of yoshi (written differently).
        yoshi -= 2;

        Debug.Log("Yoshi's value is: " + yoshi);

        Debug.Log(bee + " " + intro);

        total = mario + yoshi;

        Debug.Log(total);

        fullSentence = intro + " " + outro;

        Debug.Log(fullSentence);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(chestName);
    }
}
