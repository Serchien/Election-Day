using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    protected static int score = 0;

    [SerializeField] private TMP_Text textScore = null;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    static public int GetScore()
    {
        return score;
    }

    static public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        
    }

    void ChangeUI()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = score.ToString();

    }
}
