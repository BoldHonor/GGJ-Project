using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterLand : Creature
{
    public enum MonsterAttackBehaviour
    {
        FollowAndAttack
    };


    #region Variables

    public float AttackDistance;
    public float Speed;
    public MonsterAttackBehaviour AttackBehaviour;
    public CharacterController c;
    public Vector3 gravity = new Vector3(0, -0.05f, 0);


    #endregion Variables

    public void Start()
    {
        c= gameObject.GetComponent<CharacterController>();
    }

    public void Update()
    {
        base.Update();
        c.Move(gravity);
    }


    /// <summary>
    /// When Player is detected
    /// </summary>
    /// <param name="player"> Player GameObject </param>
    public void OnPlayerDetect(GameObject player)
    {
        switch (AttackBehaviour)
        {
            case MonsterAttackBehaviour.FollowAndAttack:
                FollowAndAttack(player);
                break;
            default:
                // code block
                break;
        };


    }


/// <summary>
/// Follow and attack behaviour of land monsters
/// </summary>
/// <param name="player"></param>
    public void FollowAndAttack(GameObject player)
    {
        var distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
        if (AttackDistance < distance)
        {
            c.Move(Speed * Time.deltaTime * Vector3.Normalize(player.transform.position - gameObject.transform.position));
            Walk();
            gameObject.transform.LookAt(player.transform);
        }
        else
        {
            Attack();
            Debug.Log("Attack " + distance);
        }
    }


}
