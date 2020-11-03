using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu(menuName = "Create Character")]

public class Character : ScriptableObject
{
    public string characterName;
    public Sprite image;


    [TextArea(2, 3)] public string promesse1;
    [TextArea(2, 3)] public string promesse2;
    [TextArea(2, 3)] public string promesse3;
}
