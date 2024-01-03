using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSM : StateMachine
{
    [HideInInspector]
    public Initial initialState;
    [HideInInspector]
    public Attack attackState;
    [HideInInspector]
    public WaitTurn waitState;
    [HideInInspector]
    public Win winState;
    [HideInInspector]
    public Lose loseState;


    [SerializeField]
    GameObject enemyObject1;
    [SerializeField]
    GameObject enemyObject2;
    [SerializeField]
    GameObject Button;
    [SerializeField]
    GameObject UI;

    [SerializeField]
    GameObject PlayerText;

    [HideInInspector]
    public BoxCollider2D enemyBox1;
    [HideInInspector]
    public BoxCollider2D enemyBox2;
    [HideInInspector]
    public Button attackButton;
    [HideInInspector]
    public Enemy enemy1;
    [HideInInspector]
    public Enemy enemy2;
    [HideInInspector]
    public MenuControl menuControl;

    [HideInInspector]
    public TMP_Text playerHealthText;

    [HideInInspector]
    public bool attackPressed = false;
    [HideInInspector]
    public bool enemyPressed = false;
    [HideInInspector]
    public bool EnemyTurnEnd = false;
    [HideInInspector]
    public bool win = false;
    [HideInInspector]
    public bool lose = false;

    public int playerHealth = 100;

    private void Awake()
    {
        enemyBox1 = enemyObject1.GetComponent<BoxCollider2D>();
        enemyBox2 = enemyObject2.GetComponent<BoxCollider2D>();
        attackButton = Button.GetComponent<Button>();
        enemy1 = enemyObject1.GetComponent<Enemy>();
        enemy2 = enemyObject2.GetComponent<Enemy>();
        menuControl = UI.GetComponent<MenuControl>();
        playerHealthText = PlayerText.GetComponent<TextMeshProUGUI>();

        enemy1.setBehavior(new AttackBehavior());
        enemy2.setBehavior(new ReadyBehavior());

        initialState = new Initial(this);
        attackState = new Attack(this);
        waitState = new WaitTurn(this);
        winState = new Win(this);
        loseState = new Lose(this);
    }

    protected override BaseState GetInitialState()
    {
        return initialState;
    }

    public void onAttack()
    {
        attackPressed = true;
    }

    public void onEnemyClick()
    {
        enemyPressed = true;
    }
}
