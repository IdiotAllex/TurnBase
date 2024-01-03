using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : BaseState
{
    private GameSM _sm;
    public Attack(GameSM stateMachine) : base("Attack", stateMachine)
    {
        _sm = (GameSM)this.stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Attacking");
        if (_sm.enemy1.isalive)
        {
            _sm.enemyBox1.enabled = true;
        }
        if (_sm.enemy2.isalive)
        {
            _sm.enemyBox2.enabled = true;
        }
        _sm.attackButton.interactable = false;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if (_sm.enemyPressed)
        {
            stateMachine.ChangeState(_sm.waitState);
        }

    }
}
