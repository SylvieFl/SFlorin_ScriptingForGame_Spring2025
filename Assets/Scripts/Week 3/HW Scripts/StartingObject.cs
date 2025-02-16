using UnityEngine;

public class StartingObject : MonoBehaviour
{
    public GameObject startingSphere;
    public GameObject startingSpawn;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            GameObject go = Instantiate(startingSphere, startingSpawn.transform.position, startingSpawn.transform.rotation);

            go.GetComponent<Rigidbody>().AddForce(Vector3.right * 200f);
        }
    }

}
