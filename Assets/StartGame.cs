using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // [SerializeField] 
    public bool canGameStart = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
            canGameStart = true;
            Destroy(GetComponentInChildren<Transform>().gameObject);
        }
    }
}
