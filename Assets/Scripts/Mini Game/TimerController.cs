using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TimerController : MonoBehaviour
{
    [SerializeField] int maxTime;
    TMP_Text textTimer;


    // Start is called before the first frame update
    void Start()
    {
        textTimer = GetComponent<TMP_Text>();
        textTimer.text = maxTime.ToString();

        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        while(maxTime != 0)
        {
            yield return new WaitForSeconds(1f);
            maxTime--;
            textTimer.text = maxTime.ToString();
        }

        SceneChanger.LoadScene("Game");
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
