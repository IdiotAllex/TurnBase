using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : BaseState
{
    private GameSM _sm;
    public Lose(GameSM stateMachine) : base("Lose", stateMachine)
    {
        _sm = (GameSM)this.stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Win");
        _sm.enemyBox1.enabled = false;
        _sm.enemyBox2.enabled = false;
        _sm.attackButton.interactable = false;

        _sm.menuControl.onLose();
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
    }
}
