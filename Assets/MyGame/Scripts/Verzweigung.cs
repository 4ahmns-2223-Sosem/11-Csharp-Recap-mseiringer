using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verzweigung : MonoBehaviour
{
    int Y = 33;

    void Start()
    {
        if (Y < 44)
        {
            Debug.Log("IMogNimma");
        }
        else
        {
            Debug.Log("IMogImmaNoNid");
        }
    }

}
