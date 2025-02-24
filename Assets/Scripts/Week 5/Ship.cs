using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Ship : MonoBehaviour
{
    public List<Cannon> cannons = new List<Cannon>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannons = FindObjectsByType<Cannon>(FindObjectsSortMode.InstanceID).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireAllCannons();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            FireEvenCannons();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            FireOddCannons();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            FireAllPowerfulCannons();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            FireAllWeakCannons();
        }
        /*
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < cannons.Count; i++) //for (local int variable for list index number = what index we want it to start at; conditional statement (saying if i is <>= to something); and increase/decrease (++/--))
            {
                cannons[i].FireCannon();
                i++;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for (int i = 1; i < cannons.Count; i++)
            {
                cannons[i].FireCannon();
                i++;
            }
        }*/
    }

    void FireAllCannons()
    {
        //This fires all cannons using a foreach loop.
        foreach (Cannon c in cannons)
        {
            c.FireCannon();
        }

        //This fires all cannons using a for loop.
        /*for (int i = 1; i < cannons.Count; i++)
        {
            cannons[i].FireCannon();
        }*/
    }

    void FireEvenCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            //The mod operator (%) does division between 2 numbers and returns the remainder. If the remainder of somthing % 2 is 0, then it is even.
            if (i % 2 == 0)
            {
                cannons[i].FireCannon();
            }
        }
    }

    void FireOddCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            if (i % 2 == 1)
            {
                cannons[i].FireCannon();
            }
        }
    }

    void FireAllPowerfulCannons()
    {
        foreach (Cannon c in cannons)
        {
            if (c.force >= 4500f)
            {
                c.FireCannon();
            }
        }
    }

    void FireAllWeakCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            if (cannons[i].force < 4500f)
            {
                cannons[i].FireCannon();
            }
        }
    }
}
