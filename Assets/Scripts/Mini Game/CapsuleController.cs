using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    Canal currentCanal;
    BoxCollider2D boxCollider;
    [SerializeField] int score = 10;


    // Start is called before the first frame update
    void Start()
    {
        currentCanal = GetComponentInParent<Canal>();
        boxCollider = GetComponent<BoxCollider2D>();

        GetComponent<SpriteRenderer>().sprite = currentCanal.spriteEllipse;

        Color colorTemp = GetComponent<SpriteRenderer>().color;
        colorTemp.a = 0.5f;
        GetComponent<SpriteRenderer>().color = colorTemp;
    }

    // Update is called once per frame
    void Update()
    {
    /*
        if (Input.GetKey("space"))
        {
            CheckCollision();
        }
        */
    }

    public void GetInput()
    {
        CheckCollision();
        StartCoroutine(CapsuleColor());
    }

    IEnumerator CapsuleColor()
    {
        Color colorTemp = GetComponent<SpriteRenderer>().color;
        colorTemp.a = 1f;
        GetComponent<SpriteRenderer>().color = colorTemp;

        yield return new WaitForSeconds(0.25f);


        colorTemp.a = 0.5f;
        GetComponent<SpriteRenderer>().color = colorTemp;



    }

    private void CheckCollision()
    {


        foreach (GameObject ellipse in currentCanal.ellipses)
        {
            if (boxCollider.IsTouching(ellipse.GetComponent<BoxCollider2D>()))
            {
                if (!ellipse) return;


                Destroy(ellipse);
                currentCanal.ellipses.Remove(ellipse);
                CalculateScore(score);
                break;

            }
            else
            {
                CalculateScore(-score);
            }

        }
        
    }

    void CalculateScore(int score)
    {
        ScoreController.AddScore(score);

    }
}
