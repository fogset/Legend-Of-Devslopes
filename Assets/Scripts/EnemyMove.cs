using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    public Transform player;

    private NavMeshAgent nav;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (!GameManager.instance.GameOver)
        {
            nav.SetDestination(player.position);
        }
        else
        {
            nav.enabled = false;
            anim.Play("Idle");
        }
    }
}
