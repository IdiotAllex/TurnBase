using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehavior : IBehavior
{
    public bool Command()
    {
        Debug.Log("AttackBehavior");
        return true;
    }
}
