using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField] private GameObject[] buttons;
    //List<int> sequence = new List<int>();
    List<int> sequence = new List<int>();
    //int stepNb = 4;
    int whatIndex = 0;

    [SerializeField] private int nbSequence = 0;
    [SerializeField] private int[] sequenceLenght = null;
    [SerializeField] private GameObject screen;

    [SerializeField] private int pointGain = 20;

    public bool sequencing = true;


    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        SequenceCreator();
    }

    void SequenceCreator()
    {
        if(whatIndex > nbSequence)
        {
            EndGame();
        }
        else
        {
            StartCoroutine(StartSequence(sequenceLenght[whatIndex]));
            whatIndex++;
        }

    }

    IEnumerator StartSequence(int stepNb)
    {        
        sequencing = true;

        yield return new WaitForSeconds(0.5f);

        for(int i = 0; i < stepNb; i++)
        {
            yield return new WaitForSeconds(0.2f);
            int indexButton = Random.Range(0, buttons.Length);
            sequence.Add(indexButton);
            //buttons[indexButton].GetComponent<ButtonBehaviour>().Activate();
            screen.GetComponent<ScreenHandler>().SetInstruction(indexButton);

            
            yield return new WaitForSeconds(1f);
        }
        sequencing = false;

    }

    public void CheckButtonInSequence(GameObject button)
    {
        if (button.Equals(buttons[sequence[0]]))
        {
            sequence.RemoveAt(0);

            if (sequence.Count == 0)
            {
                SequenceCreator();
                ScoreController.AddScore(pointGain);
            }
        }
        else
        {
            Debug.Log("bouuuu");
            whatIndex--;
            ScoreController.AddScore(-pointGain/2);
            SequenceCreator();
            sequence.Clear();
        }
    }


    void EndGame()
    {
        Debug.Log("find du jeu !");
        SceneChanger.LoadScene("Game");

    }
}
