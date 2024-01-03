using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCharacter : MonoBehaviour
{
    [SerializeField]
    public GameObject body;
    [SerializeField]
    public GameObject hair;
    [SerializeField]
    public GameObject skin;
    [SerializeField]
    public GameObject partSelect;

    public Player playerCharacter = new Player();
    private NewPlayer newPlayer = new NewPlayer();

    void Start()
    {
        DefaultBuild();
        partSelect.GetComponent<PartSelect>().setPlayer(playerCharacter);
       // Debug.Log(playerCharacter.Body.sprite);
    }
    private void DefaultBuild()
    {
        newPlayer.body = body;
        newPlayer.hair = hair;
        newPlayer.skin = skin;

        newPlayer.BuildBody();
        newPlayer.BuildHair();
        newPlayer.BuildSkin();

        playerCharacter = newPlayer.Build();
    }

}
