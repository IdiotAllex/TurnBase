using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PartSelect : MonoBehaviour
{
    public Player playerCharacter = new Player();
    private NewPlayer newPlayer = new NewPlayer();
    private ChangedPlayer changedPlayer = new ChangedPlayer();

    // Start is called before the first frame update

    [SerializeField]
    public GameObject body;
    [SerializeField]
    public GameObject hair;
    [SerializeField]
    public GameObject skin;
    [SerializeField]
    private FlexibleColorPicker picker;
    [SerializeField]
    private Sprite[] bodySprites = new Sprite[3];
    private int bodyCount = 0;
    [SerializeField]
    private Sprite[] hairSprites = new Sprite[3];
    private int hairCount = 0;
   // [SerializeField]
  //  public GameObject setChracter;

    void Start()
    {
        DefaultBuild();
        Debug.Log(playerCharacter.Body.sprite);
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
        changedPlayer.player = playerCharacter;
    }


    public void changeBody()
    {
        if (bodyCount < 2)
        {
            bodyCount++;
        }
        else
            bodyCount = 0;

        changedPlayer.sprite = bodySprites[bodyCount];
        changedPlayer.BuildBody();
        playerCharacter = changedPlayer.Build();
    }

    public void changeHair()
    {
        if (hairCount < 2)
        {
            hairCount++;
        }
        else
            hairCount = 0;

        changedPlayer.sprite = hairSprites[hairCount];
        changedPlayer.BuildHair();
        playerCharacter = changedPlayer.Build();
    }

    public void changeSkinColor()
    {
        Color skinColor = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;
        changedPlayer.color = skinColor;
        changedPlayer.BuildSkin();
        playerCharacter = changedPlayer.Build();
    }

    public void changeHairColor()
    {
        changedPlayer.color = picker.color;
        changedPlayer.BuildHairColor();
        playerCharacter = changedPlayer.Build();
    }

    public void setPlayer(Player setPlayer)
    {
        changedPlayer.player = setPlayer;

        changedPlayer.sprite = playerCharacter.Body.sprite;
        changedPlayer.BuildBody();
        changedPlayer.sprite = playerCharacter.Hair.sprite;
        changedPlayer.BuildHair();
        changedPlayer.color = playerCharacter.Hair.color;
        changedPlayer.BuildHairColor();
        changedPlayer.color = playerCharacter.Skin.color;
        changedPlayer.BuildSkin();

        setPlayer = changedPlayer.Build();
    }
}
