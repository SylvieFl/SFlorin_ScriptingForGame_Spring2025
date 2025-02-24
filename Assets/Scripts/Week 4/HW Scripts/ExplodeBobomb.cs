using UnityEngine;

public class ExplodeBobomb : MonoBehaviour
{
    public TimerBobomb timerBobomb;
    public bool willExplode;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("ExplodeColorChange", Random.Range(5, 11));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExplodeColorChange()
    {
        if (willExplode == true)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
            Invoke("Explode", 1);

        }
        else
        { 
        
        }
    }

    public void Explode()
    { 
        
    }
}
