using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed;  // 플레이어 능력치
    // float hp;
    // float vit;

    float hAxis;  // 이동관련 변수
    float vAxis;  
    bool wDown;   
    Vector3 moveVec;

    Animator anim;

    // ------------------------------ events ---------------------------------
    void Awake() 
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Start()
    {
        speed = 5.0f;
        // hp = 100.0f;
        // vit = 0.0f;
    }

    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        wDown = Input.GetButton("Walk");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        
        transform.position += moveVec * speed * (wDown ? 0.3f : 1f) * Time.deltaTime;

        anim.SetBool("isRun", moveVec != Vector3.zero);
        anim.SetBool("isWalk", wDown);
    
        transform.LookAt(transform.position + moveVec);
    }

    // ------------------------------ stats ---------------------------------
    void Attak(){}
    void SetHp(float newHp){}
    void SetVit(float newVit){}
    void SetSpeed(float newSpeed){}
}
