using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterSetup : MonoBehaviour
{
    [SerializeField] public Character character;
    [SerializeField] Image portrait;
    [SerializeField] TMP_Text characterName;
    [SerializeField] TMP_Text promesse1;
    [SerializeField] TMP_Text promesse2;
    [SerializeField] TMP_Text promesse3;

    // Start is called before the first frame update
    void Start()
    {
        portrait.sprite = character.image;
        characterName.text = character.characterName;

        promesse1.text = character.promesse1;
        promesse2.text = character.promesse2;
        promesse3.text = character.promesse3;
        
    }


}
