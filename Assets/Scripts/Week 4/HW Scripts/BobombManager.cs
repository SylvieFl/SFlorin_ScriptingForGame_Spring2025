using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BobombManager : MonoBehaviour
{
    public GameObject bobombPrefab;
    public int spawnCount = 1;
    public int randSpawnAmount;

    public bool spawning = true;
    
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    public CounterBobomb counterBobomb;

    public GameObject youWinScreen;
    public GameObject youLoseScreen;

    public List<BobombLogic> bobombs = new List<BobombLogic>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        counterBobomb = FindAnyObjectByType<CounterBobomb>();
        randSpawnAmount = Random.Range(20, 41);

        for (int i = 0; i < randSpawnAmount; i++)
        {
            BobombSpawn();
        }
    }

    void BobombSpawn()
    {
        GameObject go = Instantiate(bobombPrefab, new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ)), bobombPrefab.transform.rotation);
        bobombs.Add(go.GetComponent<BobombLogic>());
    }

    public void EndBobombCount()
    { 
        bobombs = FindObjectsByType<BobombLogic>(FindObjectsSortMode.None).ToList();
        if (counterBobomb.counterNum == bobombs.Count)
        {
            youWinScreen.SetActive(true);
            Debug.Log("You Win");
        }
        else
        {
            youLoseScreen.SetActive(true);
            Debug.Log("You Lose");
        }
    }

}
