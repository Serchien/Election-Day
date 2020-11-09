using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllipseSpawner : MonoBehaviour
{

    [SerializeField] private GameObject[] canals;
    bool isGameOn = false;
    public float difficulte = 1;

    [SerializeField] int nbEllipsesMax = 0;
    public int nbEllipses;
    int nbEllipseSpawn = 0;


    [SerializeField] StartGame tutorial = null;



    private void StartGame()
    {
        isGameOn = true;
        StartCoroutine(GameOn());
    }

    private IEnumerator GameOn()
    {
        nbEllipses = nbEllipsesMax;
        canals[0].GetComponent<Canal>().SpawnEllipse();
        nbEllipseSpawn++;


        yield return new WaitForSeconds(2);

        while (isGameOn)
        {

            yield return new WaitForSeconds(difficulte);
            int whatCanal = Random.Range(0, canals.Length);

            if (nbEllipseSpawn != nbEllipsesMax)
            {
                canals[whatCanal].GetComponent<Canal>().SpawnEllipse();
                nbEllipseSpawn++;

            }
            //nbEllipses--;

            if (nbEllipses == 0)
            {
                StopGame();
                isGameOn = false;
                break;
            }

        }
    }

    void StopGame()
    {
        Debug.Log("The Game Must Stop !!");
        SceneChanger.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {
        if(tutorial.canGameStart == true && isGameOn == false)
        {
            StartGame();
        }
    }
}
