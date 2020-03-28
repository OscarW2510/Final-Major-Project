using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginGame : MonoBehaviour
{

    public GameObject[] tilesToRemove;
    public GameObject cluePrefab;
    void OnTriggerEnter2D(Collider2D collision)
    {
        foreach(GameObject i in tilesToRemove)
        {
            GameObject clue = Instantiate(cluePrefab, this.transform);
            clue.transform.parent = null;
            clue.transform.position = this.transform.position;

            ClueMovement clueMovement = clue.GetComponent<ClueMovement>();
            clueMovement.targetPosition = i.transform.position;

            Destroy(i);

        }
        


        Destroy(this);
       
    }

        
}
