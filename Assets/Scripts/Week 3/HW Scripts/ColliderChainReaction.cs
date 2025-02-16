using UnityEditor.Rendering;
using UnityEngine;

public class ColliderChainReaction : MonoBehaviour
{
    public int chainBall = 0;

    //public GameObject ball01;
    //public GameObject ball02;
    //public GameObject ball03;

    public TriggerColorChange triggerColorChange;

    private void Awake()
    {
        triggerColorChange = FindAnyObjectByType<TriggerColorChange>();
        triggerColorChange.newSphere = this.gameObject;
        triggerColorChange.colliderChainReaction = this;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Respawn")
        { 
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0.5f, 1f, 0f) * 200f);
            chainBall++;
            triggerColorChange.ShootChainBall();
        }
    }
}
