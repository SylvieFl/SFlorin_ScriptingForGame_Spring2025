using UnityEngine;

public class Script1Int : MonoBehaviour
{
    int int1 = 49;
    int int2 = 784;
    int int3 = 2;
    int total;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        total = int1 + (int2 - int3) / int1 * int3 - (int2 - int1) * int3;

        Debug.Log("Script 1's variable 'total' is: " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
