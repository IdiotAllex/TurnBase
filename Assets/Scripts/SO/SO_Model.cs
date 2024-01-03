using UnityEngine;

[CreateAssetMenu(fileName = "new Model", menuName = "Model")]
public class SO_Model : ScriptableObject
{

    public BodyPart[] characterBodyParts;

}
    [System.Serializable]
    public class BodyPart
    {
        public string partName;
        public SO_part part;
    }
