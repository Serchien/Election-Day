using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private SliderManager sm = null;
    [SerializeField] private TMP_Text text;
    private EventManager eventManager;

    int maxMonths = 12;
    //static public int monthsRemaining = 12;


    void Start()
    {
        sm.tm = this;
        eventManager = GetComponent<EventManager>();


        text.text = StatusManager.Months.ToString();
        sm.StartSlider();
    }

    public void NewMonth()
    {
        sm.StartSlider();

    }

    void Update()
    {
        
    }
    public void ChangerMois()
    {
        StatusManager.Months--;
        text.text = StatusManager.Months.ToString();
        eventManager.NewEvent();
        //sm.StartSlider();

    }
}
