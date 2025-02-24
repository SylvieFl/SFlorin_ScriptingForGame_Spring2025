using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomSpawnBobomb : MonoBehaviour
{
    public GameObject bobombPrefab;
    public int spawnCount = 1;
    public int randSpawnAmount;

    public bool spawning = true;
    
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    public List<BobombLogic> bobombs = new List<BobombLogic>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Instantiate(bobombPrefab, new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ)), bobombPrefab.transform.rotation);
        randSpawnAmount = Random.Range(20, 41);
        Debug.Log("rand " + randSpawnAmount);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCount <= randSpawnAmount && spawning == true)
        {
            
            GameObject go = Instantiate(bobombPrefab, new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ)), bobombPrefab.transform.rotation);
            bobombs.Add(go.GetComponent<BobombLogic>());
            Debug.Log("executed");

            if (spawnCount < randSpawnAmount)
            {
                spawnCount++;
                Debug.Log(spawnCount);
            }
            else
            { 
                spawning = false;
            }
            
        }

        
    }

}
