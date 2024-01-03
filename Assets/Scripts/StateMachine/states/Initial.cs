using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initial : BaseState
{
    private GameSM _sm;
    public Initial(GameSM stateMachine) : base("Idle", stateMachine) 
    {
        _sm = (GameSM)this.stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Initial");
        _sm.playerHealthText.text = _sm.playerHealth.ToString() + "/100";
        _sm.enemyBox1.enabled = false;
        _sm.enemyBox2.enabled = false;
        _sm.attackButton.interactable = true;
        _sm.EnemyTurnEnd = false;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if (_sm.attackPressed)
        {
            stateMachine.ChangeState(_sm.attackState);
        }

    }
}
