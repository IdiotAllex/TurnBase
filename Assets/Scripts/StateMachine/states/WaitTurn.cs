using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitTurn : BaseState
{
    private GameSM _sm;
    public WaitTurn(GameSM stateMachine) : base("WaitTurn", stateMachine)
    {
        _sm = (GameSM)this.stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Waiting");
        _sm.enemyBox1.enabled = false;
        _sm.enemyBox2.enabled = false;
        if (_sm.enemy1.isalive && _sm.enemy2.isalive)
        {
            _sm.playerHealth = _sm.playerHealth - _sm.enemy1.enemyAttack();
            Debug.Log("first attack");

            _sm.playerHealth = _sm.playerHealth - _sm.enemy2.enemyAttack();
            Debug.Log("second attack");

            if (_sm.enemy2.charged == false)
            {
                _sm.enemy2.setBehavior(new ReadyBehavior());
            }
            else
                _sm.enemy2.setBehavior(new AttackBehavior());


            _sm.EnemyTurnEnd = true;
        }
        else if (_sm.enemy1.isalive && !_sm.enemy2.isalive)
        {
            _sm.playerHealth = _sm.playerHealth - _sm.enemy1.enemyAttack();
            _sm.enemy1.setBehavior(new AttackBehavior());
            _sm.EnemyTurnEnd = true;
        }
        else if (!_sm.enemy1.isalive && _sm.enemy2.isalive)
        {
            _sm.playerHealth = _sm.playerHealth - _sm.enemy2.enemyAttack();
            _sm.enemy2.setBehavior(new AttackBehavior());
            _sm.EnemyTurnEnd = true;
        }
        else
        {
            _sm.win = true;
        }

        _sm.playerHealthText.text = _sm.playerHealth.ToString() + "/100";

        if (_sm.playerHealth <= 0)
        {
            _sm.lose = true;
        }
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if (_sm.lose)
        {
            stateMachine.ChangeState(_sm.loseState);
        }
        else if (_sm.win)
        {
            stateMachine.ChangeState(_sm.winState);
        }
        else  if (_sm.EnemyTurnEnd)
        {
            _sm.attackPressed = false;
            _sm.enemyPressed = false;
            _sm.EnemyTurnEnd = false;
            stateMachine.ChangeState(_sm.initialState);
        }
    }
}
