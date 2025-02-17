using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    public List<CannonBall> cannonBalls = new List<CannonBall>();

    public GameObject cannonBallPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Finds all GameObjects in the scene that has the CannonBall script. Returns it as an Array of GameObjects that you can convert to a List.
        cannonBalls = FindObjectsByType<CannonBall>(FindObjectsSortMode.None).ToList();

        //Finds all GameObjects in the scene with the specified tag. Returns it as an Array of GameObjects that you can convert to a List.
        //GameObject.FindGameObjectsWithTag("CannonBall").ToList();


        GameObject go = Instantiate(cannonBallPrefab);
        cannonBalls.Add(go.GetComponent<CannonBall>());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //A foreach loop will go through each object in a list and allow you to do the same action for every single instance in that list.
            foreach (CannonBall ball in cannonBalls) //foreach ("object Type" "temporary name for the individual object" in "variable name of List or Array")
            {
                ball.AddRandomForce();
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            int randomBall = Random.Range(0, cannonBalls.Count);

            cannonBalls[randomBall].AddRandomForce();
        }

    }
}
