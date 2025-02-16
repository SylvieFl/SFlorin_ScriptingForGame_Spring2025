using UnityEngine;

public class TriggerColorChange : MonoBehaviour
{
    public GameObject newSphere;

    public ColliderChainReaction colliderChainReaction;

    public GameObject ball01;
    public GameObject ball02;
    public GameObject ball03;

    public int colorNum = 0;

    private void OnTriggerEnter(Collider other)
    {
        colorNum++;
        if (colorNum == 1)
        { 
            newSphere.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else if (colorNum == 2) 
        { 
            newSphere.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        else if(colorNum == 3) 
        { 
            newSphere.GetComponent<MeshRenderer>().material.color = Color.magenta;
        }
    }

    public void ShootChainBall()
    {
        if (colliderChainReaction.chainBall == 1)
        {
            ball01.GetComponent<Rigidbody>().AddForce(Vector3.right * 500f);
        }
        else if (colliderChainReaction.chainBall == 2)
        {
            ball02.GetComponent<Rigidbody>().AddForce(Vector3.right * 500f);
        }
        else if (colliderChainReaction.chainBall == 3)
        {
            ball03.GetComponent<Rigidbody>().AddForce(Vector3.right * 500f);
        }

    }
}
