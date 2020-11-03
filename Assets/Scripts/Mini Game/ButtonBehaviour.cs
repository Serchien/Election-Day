using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    SpriteRenderer sprite;
    Color colorTemp;

    ButtonHandler buttonhandler;

    void Start()
    {
        //chnager l'alpha pour qu'il soit 50%
        sprite = GetComponent<SpriteRenderer>();
        colorTemp = sprite.color;
        colorTemp.a = 0.2f;
        sprite.color = colorTemp;

        buttonhandler = GetComponentInParent<ButtonHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate()
    {
        StartCoroutine(Flash());
    }

    IEnumerator Flash()
    {
        ChangeAlpha(1f);

        yield return new WaitForSeconds(0.5f);

        ChangeAlpha(0.2f);
    }

    void ChangeAlpha(float alpha)
    {
        colorTemp.a = alpha;
        sprite.color = colorTemp;
    }



    private void OnMouseDown()
    {
        if (buttonhandler.sequencing) return;

        else
        {
            buttonhandler.CheckButtonInSequence(gameObject);
            StartCoroutine(Flash());


        }
    }


}
