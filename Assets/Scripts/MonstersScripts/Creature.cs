using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature :MonoBehaviour
{
    public float Health;
    public bool behaviour = true;
   
  
    public virtual void Attack(){}
    public virtual void Walk(){}
    public void Idle(){}
    public void Give(){}
    public void Recive(){}
    public virtual void Behaviour()
    {

    }
    public void Start()
    {
       
    }
    public void Update()
    {
        if(behaviour)
        Behaviour();
    }


    // public void OnTriggerEnter(Collider other)
    // {

    //     Debug.Log("Hello");
    // }
}
