using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieCon : MonoBehaviour
{
    Animator anim;
    GameObject player;
    Rigidbody rb;
    NavMeshAgent nvAgent;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        nvAgent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 1f)
        {
            nvAgent.isStopped = true;

        }
        else if (Vector3.Distance(player.transform.position, transform.position) < 10)
        {
            nvAgent.isStopped = false;
            nvAgent.SetDestination(player.transform.position);
        }
        else
        {
            nvAgent.isStopped = true;
        }
        anim.SetFloat("runSpeed", nvAgent.velocity.magnitude);
    }
}
