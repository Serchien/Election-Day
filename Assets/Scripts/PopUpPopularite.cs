using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpPopularite : MonoBehaviour
{
    [SerializeField] private GameObject popUpPF = null;
    [SerializeField] private Transform pos = null;
    GameObject popUp;


    [SerializeField] Color positive = new Color();
    [SerializeField] Color negative = new Color();


    public void CreatePopUp(int populariteNB)
    {
        if (populariteNB == 0) return;

        popUp = Instantiate(popUpPF, gameObject.transform);
        popUp.transform.position = pos.position;
        //targetPos = popUp.GetComponent<Transform>().position.y + 50f;

        if(populariteNB > 0)
        {
            popUp.GetComponentInChildren<TMP_Text>().color = positive;
            popUp.GetComponentInChildren<TMP_Text>().text = "+ " + populariteNB.ToString() + "%";
        }
        else
        {
            popUp.GetComponentInChildren<TMP_Text>().color = negative;
            popUp.GetComponentInChildren<TMP_Text>().text = populariteNB.ToString() + "%";

        }

        //StartCoroutine(Anim(popUp));
    }
    private void FixedUpdate()
    {

    }


}
