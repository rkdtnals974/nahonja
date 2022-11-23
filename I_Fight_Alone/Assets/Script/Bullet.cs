using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    Vector3 startPos;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor"){
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Destroy(gameObject, 5.0f);
    }
}
