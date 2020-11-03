using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    private TimeManager timeManager;
    [SerializeField] private EventCreator[] allEvents;
    EventChoiceController controller;

    [SerializeField] GameObject eventPF;
    [SerializeField] GameObject city;

    private int currentIndex;
    private int nbOfMonth = 12;

    GameObject currentEvent;

    void Start()
    {
        timeManager = GetComponent<TimeManager>();
        controller = GetComponent<EventChoiceController>();
    }

    public void NewEvent()
    {
        currentIndex = nbOfMonth - (StatusManager.Months + 1);
        if(currentIndex > allEvents.Length - 1)
        {
            Debug.Log("need more events !");
            return;
        }
        currentEvent = Instantiate(eventPF);
        currentEvent.GetComponent<SetupEvent>().currentEvent = allEvents[currentIndex];
        currentEvent.GetComponent<EventChoiceController>().manager = this;
        //currentIndex++;
        
    }

    public void Choice1()
    {
        if(currentEvent.GetComponent<SetupEvent>().currentEvent.minigame == true)
        {
            SceneChanger.LoadScene(allEvents[currentIndex].sceneChoice1);
        }
        else
        {
            int reward = currentEvent.GetComponent<SetupEvent>().currentEvent.rewardChoice1;
            GetComponent<StatusManager>().Addpop(reward);
        }
        city.GetComponent<VisualManager>().AddChange(currentEvent.GetComponent<SetupEvent>().currentEvent.visualChange1);
        Destroy(currentEvent);
        GetComponent<TimeManager>().NewMonth();
    }

    public void Choice2()
    {
        if (currentEvent.GetComponent<SetupEvent>().currentEvent.minigame == true)
        {
            SceneChanger.LoadScene(allEvents[currentIndex].sceneChoice2);
        }
        else
        {
            int reward = currentEvent.GetComponent<SetupEvent>().currentEvent.rewardChoice2;
            GetComponent<StatusManager>().Addpop(reward);
        }
        city.GetComponent<VisualManager>().AddChange(currentEvent.GetComponent<SetupEvent>().currentEvent.visualChange2);
        Destroy(currentEvent);
        GetComponent<TimeManager>().NewMonth();

    }

}
