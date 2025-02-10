using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    public GameObject cannonBallPrefab;

    public GameObject cannonBallSpawnPosition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //cannonBall.name = "HELLO!";
        //Instantiate(cannonBallPrefab);

        //This instantiate version spawns the cannonBallPrefab, at the cannonBallSpawnPosition's position, with the same rotation it is in the prefab.
        GameObject go = Instantiate(cannonBallPrefab, cannonBallSpawnPosition.transform.position, cannonBallPrefab.transform.rotation);

        go.GetComponent<MeshRenderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(cannonBallPrefab);
        if (Input.GetKey(KeyCode.Space)) //If we are holding down the space key...
        { 
            Instantiate(cannonBallPrefab, cannonBallSpawnPosition.transform.position, cannonBallPrefab.transform.rotation);
        }
    }
}
