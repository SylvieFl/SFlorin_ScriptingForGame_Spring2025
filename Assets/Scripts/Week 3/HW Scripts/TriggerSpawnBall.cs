using UnityEngine;

public class TriggerSpawnBall : MonoBehaviour
{
    public GameObject startingSphere2;
    public GameObject sphere2Spawn;

    private void OnTriggerEnter(Collider other)
    {
        GameObject go = Instantiate(startingSphere2, sphere2Spawn.transform.position, sphere2Spawn.transform.rotation);

        go.GetComponent<Rigidbody>().AddForce(new Vector3(-1f, -1f, 0f) * 450f);
        
    }
}
