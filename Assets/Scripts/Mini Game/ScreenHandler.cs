using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenHandler : MonoBehaviour
{
    [SerializeField] GameObject[] screenInstruction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetInstruction(int index)
    {
        StartCoroutine(Instruction(index));
    }

    IEnumerator Instruction(int index)
    {
        screenInstruction[index].SetActive(true);
        yield return new WaitForSeconds(1f);
        screenInstruction[index].SetActive(false);



    }
}
