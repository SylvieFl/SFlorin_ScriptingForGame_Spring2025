using UnityEngine;

public class RotateAroundTest : MonoBehaviour
{
    public Transform rotateAxis;
    public Transform button;
    public bool isRotating = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating == true)
        {
            Spin();
        }
    }

    public void RotateButton()
    {
        isRotating = !isRotating;
    }

    public void Spin()
    {
        button.RotateAround(rotateAxis.position, Vector3.back, 270 * Time.deltaTime);
    }
}
