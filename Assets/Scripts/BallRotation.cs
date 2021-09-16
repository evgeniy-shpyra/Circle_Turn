using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] GameObject CenterRing;

    bool direction = false;

    void FixedUpdate() 
    {
        if (direction == false)
            CenterRing.transform.Rotate(0, 0, 140 * Time.deltaTime);
        else
            CenterRing.transform.Rotate(0, 0, -140 * Time.deltaTime);
    }

    public void ChangeDirection()
    {
        direction = !direction;
    }

}
