using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonpressManager : MonoBehaviour
{
    Text text;
    int nb = 0;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }
    public void UpdateText()
    {
        nb++;
        text.text = "Button press : " + nb.ToString();
    }
}
