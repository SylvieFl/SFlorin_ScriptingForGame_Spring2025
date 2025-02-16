using UnityEngine;

public class ColliderLeftForce : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-1f, 2f, 0) * 500f);
    }
}
