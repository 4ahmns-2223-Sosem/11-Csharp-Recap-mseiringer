using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSchleife : MonoBehaviour
{

    void Start()
    {
        for (int Y = 20; Y <= 40; Y++)
        {
            Debug.Log(Y);
        }
    }
}
