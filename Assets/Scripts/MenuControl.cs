using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject MainMenu;
    [SerializeField]
    GameObject CharacterSelect;
    [SerializeField]
    GameObject GameScreen;
    [SerializeField]
    GameObject WinScreen;
    [SerializeField]
    GameObject LoseScreen;

    public void onStart()
    {
        MainMenu.SetActive(false);
        CharacterSelect.SetActive(true);
    }
    public void onEnd()
    {
        Application.Quit();
    }
    public void onBack()
    {
        MainMenu.SetActive(true);
        CharacterSelect.SetActive(false);
    }

    public void onDone()
    {
        CharacterSelect.SetActive(false);
        GameScreen.SetActive(true);
    }

    public void onWin()
    {
        WinScreen.SetActive(true);
    }
    public void onLose()
    {
        LoseScreen.SetActive(true);
    }
}
