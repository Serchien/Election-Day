using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetupEvent : MonoBehaviour
{
    [SerializeField] private TMP_Text title_text = null;
    //[SerializeField] private TMP_Text description_text = null;
    [SerializeField] private TMP_Text choice1_text = null;
    [SerializeField] private TMP_Text choice2_text = null;

    public EventCreator currentEvent;

    // Start is called before the first frame update
    void Start()
    {

        title_text.text = currentEvent.title;
        //description_text.text = currentEvent.description;
        choice1_text.text = currentEvent.choice1;
        choice2_text.text = currentEvent.choice2;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
