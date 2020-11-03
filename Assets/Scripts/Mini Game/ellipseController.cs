using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ellipseController : MonoBehaviour
{
    public Canal whatCanal;



    private void OnDestroy()
    {
        whatCanal.ellipses.Remove(gameObject);
        whatCanal.gameObject.GetComponentInParent<EllipseSpawner>().nbEllipses--;

    }


}
