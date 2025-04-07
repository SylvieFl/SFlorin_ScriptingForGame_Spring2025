using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange;

    public float attackSpeed;

    private float attackTimer;

    protected Player player;

    protected NavMeshAgent navAgent;

    [SerializeField]
    protected float aggroRange = 30f;

    protected bool hasSeenPlayer = false;

    [SerializeField]
    protected List<Transform> patrolPoints = new List<Transform>();

    protected int patrolPointIndex = 0;

    protected virtual void Start()
    {
        player = FindAnyObjectByType<Player>();
        navAgent = GetComponent<NavMeshAgent>();
        navAgent.SetDestination(patrolPoints[patrolPointIndex].position);
    }

    protected virtual void Update()
    {
        if (hasSeenPlayer == true)
        {
            if (navAgent.remainingDistance < 0.5f)
            {
                if (Vector3.Distance(this.transform.position, player.transform.position) > aggroRange)
                {
                    hasSeenPlayer = false;
                }
                else
                {
                    if (isPlayerInLOS() == true)
                    {
                        navAgent.SetDestination(player.transform.position);
                        navAgent.isStopped = false;
                    }
                    else
                    {
                        hasSeenPlayer = false;
                    }
                }
            }


            if (Vector3.Distance(this.transform.position, player.transform.position) > attackRange)
            {
                if (isPlayerInLOS() == true)
                {
                    navAgent.SetDestination(player.transform.position);
                    navAgent.isStopped = false;
                }
            }   
            else
            {
                if (isPlayerInLOS() == true)
                {
                    navAgent.isStopped = true;
                    this.transform.LookAt(player.transform.position);

                    attackTimer += Time.deltaTime;

                    if (attackTimer > attackSpeed)
                    {
                        Attack();
                        attackTimer = 0;
                    }
                }
                else
                {
                    navAgent.isStopped = false;
                    navAgent.SetDestination(patrolPoints[patrolPointIndex].position);
                }
            }
        }
        else
        {
            navAgent.isStopped = false;
            if (navAgent.remainingDistance < 0.5f)
            {
                patrolPointIndex++;

                if (patrolPointIndex >= patrolPoints.Count)
                {
                    patrolPointIndex = 0;
                }

                navAgent.SetDestination(patrolPoints[patrolPointIndex].position);
            }
        }
    }

    protected virtual void Attack()
    {
        player.TakeDamage(attackDamage);
        //Call an Animation on Attack
        //OR
        //Deal Damage to the Player
    }

    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;
    }

    public void Die()
    {
        //Call Death Animation
        //OR
        //Destroy the Object
    }

    public void SeePlayer()
    {
        RaycastHit hit;
        Vector3 dir = player.transform.position - this.transform.position;
        dir.Normalize();

        if (Physics.Raycast(this.transform.position, dir, out hit))
        {
            if (hit.collider.tag == "Player")
            {
                hasSeenPlayer = true;
            }
            //else
            //{
                //hasSeenPlayer = false;
            //}
        }

    }

    protected bool isPlayerInLOS()
    {
        RaycastHit hit;
        Vector3 dir = player.transform.position - this.transform.position;
        dir.Normalize();

        if (Physics.Raycast(this.transform.position, dir, out hit))
        {
            if (hit.collider.tag == "Player")
            {
                return true;
            }
        }

        return false;
    }
}
