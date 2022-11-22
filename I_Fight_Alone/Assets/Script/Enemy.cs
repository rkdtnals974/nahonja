using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{   
    GameObject Target;
    NavMeshAgent nav;

    // Mob stats
    float hp;
    float speed;
    float power;

    // ------------------------------ events ---------------------------------
    void Awake()
    {
        this.nav = GetComponent<NavMeshAgent>();
    }

    void Start() 
    {
        this.Target = GameObject.Find("Player");

        // hp = 100.0f;
        // speed = 3.0f;
        // power = 5;
    }

    void Update()
    {
        nav.SetDestination(Target.transform.position);
    }

    // ------------------------------ stats ---------------------------------
    void SetSpeed(float newSpeed)
    {
        nav.speed = newSpeed;
    }

    void SetHp(float newHp){}
    void SetPower(float newPower){}
}
