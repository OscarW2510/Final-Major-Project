using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginGame : MonoBehaviour

{
    public GameObject[] TilestoRemove;
    void OnTriggerEnter2D(Collider2D collision)
    {
        foreach(GameObject i in TilestoRemove)
        {
            Destroy(i);
        }

        Destroy(this);
    }

 
}
