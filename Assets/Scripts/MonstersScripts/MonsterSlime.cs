using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSlime : Creature
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
    }



    public override void Behaviour()
    {
        Debug.Log("Hello");
    } 
}
