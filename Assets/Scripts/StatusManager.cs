using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{
    public static int popularite = 0;
    public static int Months = 12;

    public static Sprite character;
    [SerializeField] Image characterImage;

    [SerializeField] private TMP_Text text;

    [SerializeField] private PopUpPopularite populariteAnim;

    // Start is called before the first frame update
    void Start()
    {
        Addpop(ScoreController.GetScore() / 5);
        characterImage.sprite = character;

    }

    public void Addpop(int popNb)
    {
        popularite += popNb;
        populariteAnim.GetComponent<PopUpPopularite>().CreatePopUp(popNb);
    }


    // Update is called once per frame
    void Update()
    {
        text.text = popularite.ToString() + " %";

        if (Input.GetButtonDown("Jump"))
        {
            Addpop(5);
        }
    }
}
