using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{   
    GameObject Target;
    NavMeshAgent nav;

    void Awake()
    {
        this.nav = GetComponent<NavMeshAgent>();
    }
    void Start() 
    {
        this.Target = GameObject.Find("Player");   
    }
    void Update()
    {
        nav.SetDestination(Target.transform.position);
    }
}
