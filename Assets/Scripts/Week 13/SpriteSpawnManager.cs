using UnityEngine;

public class SpriteSpawnManager : MonoBehaviour
{
    public GameObject eeveePrefab;
    public GameObject pichuPrefab;
    public GameObject pikachuPrefab;
    public GameObject psyduckPrefab;

    public int randomDecoySpawn;

    public int numEev;
    public int numPich;
    public int numPika;
    public int numPsy;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomDecoySpawn = Random.Range(15, 26);

        SpriteSpawner();
    }

    public void SpriteSpawner()
    {
        int totalDecoySpawn = randomDecoySpawn * 3;
        int whenWillPsyduckSpawn = Random.Range(0, totalDecoySpawn);

        for (int i = 0; i <= totalDecoySpawn; i++)
        {
            if (i == whenWillPsyduckSpawn)
            {
                Instantiate(psyduckPrefab, new Vector3(Random.Range(-3.25f, 3.25f), Random.Range(-3.75f, 3.75f), 0f), eeveePrefab.transform.rotation);
                numPsy++;
                i++;
            }

            Instantiate(eeveePrefab, new Vector3(Random.Range(-3.25f, 3.25f), Random.Range(-3.75f, 3.75f), 0f), eeveePrefab.transform.rotation);
            numEev++;

            if (i == whenWillPsyduckSpawn)
            {
                Instantiate(psyduckPrefab, new Vector3(Random.Range(-3.25f, 3.25f), Random.Range(-3.75f, 3.75f), 0f), eeveePrefab.transform.rotation);
                i++;
                numPsy++;
            }

            Instantiate(pichuPrefab, new Vector3(Random.Range(-3.25f, 3.25f), Random.Range(-3.75f, 3.75f), 0f), eeveePrefab.transform.rotation);
            i++;
            numPich++;

            if (i == whenWillPsyduckSpawn)
            {
                Instantiate(psyduckPrefab, new Vector3(Random.Range(-3.25f, 3.25f), Random.Range(-3.75f, 3.75f), 0f), eeveePrefab.transform.rotation);
                i++;
                numPsy++;
            }

            Instantiate(pikachuPrefab, new Vector3(Random.Range(-3.25f, 3.25f), Random.Range(-3.75f, 3.75f), 0f), eeveePrefab.transform.rotation);
            i++;
            numPika++;

            if (i == whenWillPsyduckSpawn)
            {
                Instantiate(psyduckPrefab, new Vector3(Random.Range(-3.25f, 3.25f), Random.Range(-3.75f, 3.75f), 0f), eeveePrefab.transform.rotation);
                i++;
                numPsy++;
            }

            Debug.Log(i);
        }

    }

}
