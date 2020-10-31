using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ★追加
using UnityEngine.AI;

public class Enemy2 : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = target.transform.position;
    }
}