using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu(menuName ="Create Event")] 

public class EventCreator : ScriptableObject
{
    [Header("Event")]

    [TextArea(2, 3)] public string title;
    //[TextArea(4,6)] public string description;

    [Header("Choix de l'event")]

    [TextArea(2, 3)] public string choice1;
    [TextArea(2, 3)] public string choice2;

    public bool minigame;
    public int rewardChoice1;
    public int rewardChoice2;

    [Header("Scene vers lesquelles les choix vont pointer")]
    public string sceneChoice1;
    public string sceneChoice2;

    [Header("id du changement visuelle")]
    public string visualChange1;
    public string visualChange2;


}
