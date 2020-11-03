using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    Slider slider;
    int seconds = 3;
    public TimeManager tm;


    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 0;
    }


    public void StartSlider()
    {
        StartCoroutine("UnMois");
    }

    private IEnumerator UnMois()
    {
        slider.value = 0;
        while(slider.value < 1)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            slider.value += 1 /(seconds / Time.deltaTime);
        }

        tm.ChangerMois();


    }
}
