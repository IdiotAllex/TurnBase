using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyClick : MonoBehaviour
{
    public GameObject GameState;
   // Attack state;
    Color startColor;
    [SerializeField]
    int health;
    private void OnMouseUpAsButton()
    {
        GameState.GetComponent<GameSM>().onEnemyClick();

        health = health -10;
        if (health <= 0)
        {
            transform.GetComponent<Enemy>().isalive = false;
            transform.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    private void Start()
    {
        startColor = transform.GetComponent<SpriteRenderer>().color;
    }

    void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.red;
    }

    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = startColor;
    }
}
