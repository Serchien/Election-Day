using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canal : MonoBehaviour
{
    [SerializeField] private GameObject ellipsePF = null;
    [SerializeField] private Transform posBase = null;

    public Color colorCapsule;
    [SerializeField] private Color colorEllipse;


    [SerializeField] public Sprite spriteEllipse = null;
    //[SerializeField] private Sprite spriteCapsule = null;


    public List<GameObject> ellipses = new List<GameObject>();

    void Start()
    {
        //InvokeRepeating("SpawnEllipse", 1, 3);
    }


    private void OnDestroy()
    {
        //ellipses.Remove(gameObject);
    }

    public void SpawnEllipse()
    {
        GameObject go = Instantiate(ellipsePF);
        go.transform.position = posBase.position;

        go.GetComponent<SpriteRenderer>().sprite = spriteEllipse;
        //go.GetComponent<SpriteRenderer>().color = colorEllipse;
        go.GetComponent<ellipseController>().whatCanal = this;
        ellipses.Add(go);


    }
}
