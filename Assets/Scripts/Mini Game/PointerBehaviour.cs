using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerBehaviour : MonoBehaviour
{
    [SerializeField] float speed = 1;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
