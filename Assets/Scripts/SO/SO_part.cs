using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "new Part", menuName = "BodyPart")]
public class SO_part : ScriptableObject

{
    public string partName;
    public int index;

    public Image image;
}