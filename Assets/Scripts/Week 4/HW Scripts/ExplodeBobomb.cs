using UnityEngine;

public class ExplodeBobomb : MonoBehaviour
{
    public TimerBobomb timerBobomb;
    public int randBomb;

    public BobombManager bobombManager;

    public AudioSource audioSource;
    public AudioClip explosionSFX;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerBobomb = FindAnyObjectByType<TimerBobomb>();
        bobombManager = FindAnyObjectByType<BobombManager>();
        Invoke("WhatWillExplode", Random.Range(5, 11));
        audioSource.clip = explosionSFX;
    }

    public void WhatWillExplode()
    {
        if (timerBobomb.timerDuration > 5f)
        {
            randBomb = Random.Range(0, bobombManager.bobombs.Count);
            //Debug.Log(randBomb);

            if (bobombManager.bobombs[randBomb] != null)
            {
                ExplodeColorChange();
            }
            else
            {
                WhatWillExplode();
            }
        }
    }

    public void ExplodeColorChange()
    {
        bobombManager.bobombs[randBomb].gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        Invoke("Explode", 1f);
    }

    public void Explode()
    {
        Destroy(bobombManager.bobombs[randBomb].gameObject);
        audioSource.PlayOneShot(explosionSFX);
        //Debug.Log("Explode");
        Invoke("WhatWillExplode", Random.Range(5, 10));
    }
}
