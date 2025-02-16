using UnityEngine;

public class TriggerYay : MonoBehaviour
{
    public GameObject yaySpawn01;
    public GameObject yaySpawn02;

    public GameObject yaySphere;

    public AudioSource yayAudioSource;
    public AudioClip yayClip;

    public int sphereCollected;

    private void Start()
    {
        yayAudioSource.clip = yayClip;
    }
    private void Update()
    {
        if (sphereCollected == 1)
        {
            GameObject go = Instantiate(yaySphere, yaySpawn01.transform.position, yaySpawn01.transform.rotation);
            go.GetComponent<Rigidbody>().AddForce(Vector3.left * 100f);

            GameObject go2 = Instantiate(yaySphere, yaySpawn02.transform.position, yaySpawn02.transform.rotation);
            go2.GetComponent<Rigidbody>().AddForce(Vector3.right * 100f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        sphereCollected++;
        if (sphereCollected == 1) 
        {
            yayAudioSource.Play();
        } 
    }
}
