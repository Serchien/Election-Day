using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualManager : MonoBehaviour
{
    public visualBehaviour[] allPossibleChanges;
    List<string> AllString = new List<string>();

    //static List<GameObject> visualChanges = new List<GameObject>();
    static List<string> visualChanges = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (string st in visualChanges)
        {
            //st.GetComponent<visualBehaviour>().SettinActive();
            foreach (visualBehaviour vb in allPossibleChanges)
            {
                if(vb.id == st)
                {
                    vb.SettinActive();
                }
            }
        }

    }

     public void AddChange(string id)
    {
        foreach (visualBehaviour vb in allPossibleChanges)
        {
            //AllString.Add(vb.id);
            if (vb.id == id)
            {
                // visualChanges.Add vb.gameObject
                visualChanges.Add(vb.id);
                vb.SettinActive();
            }
        }
    }
    /*
    GameObject FindGameobject()
    {
        foreach (string st in AllString)
        {
            foreach(visualBehaviour vb in allPossibleChanges)
            {

            }
        }
    }
    */

    // Update is called once per frame
    void Update()
    {
        
    }
}
