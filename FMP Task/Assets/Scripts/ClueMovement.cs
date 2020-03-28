using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueMovement : MonoBehaviour
{
    public Vector2 targetPosition;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, 0.03f);

        Vector2 currentposition = new Vector2(transform.position.x, transform.position.y);

        if (currentposition == targetPosition)
        {
            Destroy(gameObject);
        }
    }
}
