using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MonsterSlime : MonsterLand
{
    bool Detected = false;
    public Animator an;
    void Start()
    {
        base.Start();
        an = gameObject.GetComponent<Animator>();
    }
  
   void Update()
   {
        base.Update();

    }


    public override void Behaviour()
    {
        if(Detected)
            OnPlayerDetect(GameObject.Find("Player"));
        else
        Walk();
    }

    void OnTriggerEnter(Collider other)
    {
        Detected = true;
    }
    void OnTriggerExit(Collider other)
    {
        Detected = false;
    }

    public override void Attack()
    {
        an.SetBool("Attack", true);
    }
    public override void Walk()
    {
        an.SetBool("Attack", false);
    }
}
