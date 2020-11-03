using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderPatrol : MonoBehaviour
{
    //BoxCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        //collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        ScoreController.AddScore(-10);
    }

}
