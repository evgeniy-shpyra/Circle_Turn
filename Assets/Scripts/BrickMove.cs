using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMove : MonoBehaviour
{

    private float speed;

    private void Start()
    {
        if (ManagerElement.isSpeed)
            speed = 2.0f;
        else
            speed = 3.5f;     
    }

    private void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

}
