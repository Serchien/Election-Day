using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offSetAnimator : MonoBehaviour
{
    [SerializeField] float offSet = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetFloat("OffSetBouer", offSet);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
