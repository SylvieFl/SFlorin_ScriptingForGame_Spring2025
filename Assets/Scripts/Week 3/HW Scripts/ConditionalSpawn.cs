using UnityEngine;

public class ConditionalSpawn : MonoBehaviour
{
    public int sphereCollected;
    public GameObject newSphere;
    public GameObject newSpawn;

    private void OnCollisionEnter(Collision collision)
    {
        sphereCollected++;
        if (sphereCollected == 2)
        { 
            Instantiate(newSphere, newSpawn.transform.position, newSpawn.transform.rotation);
        }
    }
}
