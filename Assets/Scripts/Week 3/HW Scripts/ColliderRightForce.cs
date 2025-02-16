using UnityEngine;

public class ColliderRightForce : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(1f, 0.25f, 0) * 450f);
    }
}
