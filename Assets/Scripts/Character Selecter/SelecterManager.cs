using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecterManager : MonoBehaviour
{
    //[SerializeField] Character[] characters;
    [SerializeField] GameObject[] characterChoices;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            StatusManager.character = characterChoices[0].GetComponent<CharacterSetup>().character.image;
            SceneChanger.LoadScene("Game");
        }

        if (Input.GetKey("2"))
        {
            StatusManager.character = characterChoices[1].GetComponent<CharacterSetup>().character.image;
            SceneChanger.LoadScene("Game");
        }

    }

    public void Character1()
    {
        StatusManager.character = characterChoices[0].GetComponent<CharacterSetup>().character.image;
        SceneChanger.LoadScene("Game");
    }

    public void Character2()
    {
        StatusManager.character = characterChoices[1].GetComponent<CharacterSetup>().character.image;
        SceneChanger.LoadScene("Game");
    }
}
