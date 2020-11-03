using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpBehaviour : MonoBehaviour
{

    float targetPos;

    private void Start()
    {
        targetPos = transform.position.y + 50;
    }


    void FixedUpdate()
    {
        Transform parent = transform;
        if (parent.position.y < targetPos)
        {
            parent.position = new Vector2(parent.position.x, parent.position.y + 1);
            gameObject.GetComponentInChildren<TMP_Text>().alpha -= 0.015f;

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
