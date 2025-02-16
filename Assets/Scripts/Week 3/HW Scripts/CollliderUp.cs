using UnityEngine;

public class CollliderUp : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(1f, 1f, 0f) * 500f);
    }
}
