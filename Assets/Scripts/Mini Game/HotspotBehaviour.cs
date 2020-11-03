using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotspotBehaviour : MonoBehaviour
{
    BoxCollider2D hotspotCollider;
    [SerializeField] CircleCollider2D pointerCollider = null;
    [SerializeField] int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        hotspotCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            CheckCollision();
        }
    }

    void CheckCollision()
    {
        if (hotspotCollider.IsTouching(pointerCollider))
        {
            PlaceHotSpot();
            ScoreController.AddScore(score);

        }

        else
        {
            ScoreController.AddScore(-score);
        }

    }

    void PlaceHotSpot()
    {
        float pos = GetRandomPosition();
        //Transform posTemp = transform;
        transform.localPosition = new Vector2(transform.localPosition.x, GetRandomPosition());
        transform.localScale = new Vector2(transform.localScale.x, GetRandomScale());

        //transform.position = posTemp.position;



    }

    float GetRandomPosition()
    {
        float pos;
        pos = Random.Range(-0.35f, 0.35f);
        return pos;
    }

    float GetRandomScale()
    {
        float scale;
        scale = Random.Range(0.15f, 0.35f);
        return scale;
    }

}
