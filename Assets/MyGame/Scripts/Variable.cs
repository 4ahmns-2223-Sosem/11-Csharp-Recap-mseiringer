using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    public string WORT;
    private float ZAHL;
    public bool MTINCoolOderNid;

    //Aufrufen und Wert zuweisen von verschiedenen Variablen.
    void Start()
    {
        WORT= "IKennMiNidAusIMogNimma";
        ZAHL = 77;
    }
}
