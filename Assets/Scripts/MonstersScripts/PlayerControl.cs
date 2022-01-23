using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    private static PlayerControl copyinstance;
    public void Awake()
    {
        copyinstance = this;
    }
    public static PlayerControl instance
    {
        get
        {
            return copyinstance;
        }
    }
    public void Move(){}
   public void Sprint(){}
   public void Attack(){}
   public void Jump(){}
   public void Switch(){}
}
