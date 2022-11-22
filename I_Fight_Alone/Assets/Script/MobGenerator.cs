using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobGenerator : MonoBehaviour
{
    public GameObject enemyA;
    public Transform target;
    float delta = 0;
    float span = 0.5f;
    
    void Start()
    {
    }

    void Update()
    {
        Vector3 targetPos = target.position;
        if(targetPos.x > 0){targetPos.x -= 5;}
        else{targetPos.x += 5;}
        if(targetPos.z > 0){targetPos.z -= 5;}
        else{targetPos.z += 5;}

        this.delta += Time.deltaTime;
        if(this.delta >= this.span)
        {
            this.delta = 0;
            GameObject go;
            go = Instantiate(this.enemyA) as GameObject;
            go.transform.position = targetPos;
        }
    }
}
