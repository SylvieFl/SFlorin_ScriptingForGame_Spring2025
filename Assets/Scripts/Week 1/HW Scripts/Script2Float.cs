using UnityEngine;

public class Script2Float : MonoBehaviour
{
    public float float1;
    public float float2;
    public float float3;
    float total;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        total = float2 - float1 * (float3 + float1) / float2 + float2 * float3 - float1;

        Debug.Log("Script 2's variable 'total' is: " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
