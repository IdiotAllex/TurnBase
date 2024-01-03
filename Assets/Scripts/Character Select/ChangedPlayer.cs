using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangedPlayer : AbstractBuilder
{
    public Player player;
    public Sprite sprite;
    public Color color;

    public override void BuildBody()
    {
        player.Body.sprite = sprite;
    }

    public override void BuildHair()
    {
        player.Hair.sprite = sprite;
    }
    public void BuildHairColor()
    {
        player.Hair.color = color;
    }


    public override void BuildSkin()
    {
        player.Skin.color = color;
    }

    public override Player Build()
    {
        return player;
    }
}
