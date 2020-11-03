using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventChoiceController : MonoBehaviour
{
    bool asChoiceBeenMade = false;
    public EventManager manager;
    

    // Start is called before the first frame update
    void Start()
    {
        //manager = GetComponent<EventManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1") && !asChoiceBeenMade)
        {
            asChoiceBeenMade = true;
            manager.Choice1();
        }
        else if (Input.GetKey("2") && !asChoiceBeenMade)
        {
            asChoiceBeenMade = true;
            manager.Choice2();

        }

    }

    public void Choice1()
    {
        asChoiceBeenMade = true;
        manager.Choice1();
    }

    public void Choice2()
    {
        asChoiceBeenMade = true;
        manager.Choice2();
    }
}
