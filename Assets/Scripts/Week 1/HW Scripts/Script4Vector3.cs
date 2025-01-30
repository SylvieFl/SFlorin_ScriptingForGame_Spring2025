using UnityEngine;

public class Script4Vector3 : MonoBehaviour
{
    public Vector3 setPosition;
    public Vector3 movingPosition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = setPosition;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += movingPosition * Time.deltaTime;
    }
}
