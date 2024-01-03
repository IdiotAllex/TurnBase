using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyBehavior : IBehavior
{
    public bool Command()
    {
        Debug.Log("ReadyBehavior");
        return false;
    }
}
