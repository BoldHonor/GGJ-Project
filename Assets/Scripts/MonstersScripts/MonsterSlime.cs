using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterSlime : Creature
{
    public float detectionradius = 10f;
    public float detectionangle = 180f;

    private PlayerControl target;
    private NavMeshAgent navMeshAgent;
    
    // Update is called once per frame
    void Update()
    {
        base.Update();
        lookforplayer();

        target = lookforplayer();
        if (!target) { return; }

        Vector3 targetposition = target.transform.position;
        navMeshAgent.SetDestination(targetposition);
    }

    private PlayerControl lookforplayer()
    {
        if(PlayerControl.instance==null){
            return null;
        }
        Vector3 Mslimeposition = transform.position;
        Vector3 distancebtw = PlayerControl.instance.transform.position - Mslimeposition;
        distancebtw.y = 0f;

        if(distancebtw.magnitude<= detectionradius)
        {
            if(Vector3.Dot(distancebtw.normalized,transform.forward)>
                Mathf.Cos(detectionangle * 0.5f * Mathf.Deg2Rad))
                {

                return PlayerControl.instance;
            }
        }

        return null;
    }
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }


    public override void Behaviour()
    {
        Debug.Log("Hello");
    } 
}
