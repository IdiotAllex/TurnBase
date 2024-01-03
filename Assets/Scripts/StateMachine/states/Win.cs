using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : BaseState
{
    private GameSM _sm;
    public Win(GameSM stateMachine) : base("Win", stateMachine)
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

        _sm.menuControl.onWin();
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
    }
}
