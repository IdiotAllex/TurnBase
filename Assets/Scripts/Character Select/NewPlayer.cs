using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPlayer : AbstractBuilder
{
    public Player player = new Player();


    public GameObject body;
    public GameObject hair;
    public GameObject skin;


    public override void BuildBody()
    {
        player.Body = body.GetComponent<Image>();
    }

    public override void BuildHair()
    {
        player.Hair = hair.GetComponent<Image>();
    }

    public override void BuildSkin()
    {
        player.Skin = skin.GetComponent<Image>();
    }

    public override Player Build()
    {
        return player;
    }
}
