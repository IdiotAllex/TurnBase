using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract public class AbstractBuilder : MonoBehaviour
{
        public abstract void BuildBody();
        public abstract void BuildHair();
        public abstract void BuildSkin();
        public abstract Player Build();
}
