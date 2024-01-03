using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    IBehavior behavior;
    public bool charged = false;
    public bool isalive = true;
    public string enemyName;


    [SerializeField]
    GameObject EnemyText;
    [HideInInspector]
    public TMP_Text enemyActionText;

    private void Start()
    {
        enemyActionText = EnemyText.GetComponent<TextMeshProUGUI>();  
    }
    public void setBehavior(IBehavior behavior)
    {
        this.behavior = behavior;
    }

    public IBehavior GetBehavior()
    {
        return behavior;
    }

    public int enemyAttack()
    {
        if (behavior.Command())
        {
            if (charged)
            {
                    enemyActionText.text = enemyName + " makes a massive attack!";
                    charged = false;
                    StartCoroutine(Coroutine());
                    return 20;
                
            }
            else
            {
                    enemyActionText.text = enemyName + " makes an attack!";
                    StartCoroutine(Coroutine());
                    return 5;
            }
        }
        else 
        {
                enemyActionText.text = enemyName + " is getting ready...";
                charged = true;
                StartCoroutine(Coroutine());
                return 0;

        }
    }  
    IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(2);
        enemyActionText.text = "";
    }
}
