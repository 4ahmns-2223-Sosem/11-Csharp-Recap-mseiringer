using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Done,
    WIP,
    Cancel
}

public class MyEnums : MonoBehaviour
{
    //Deklaration
    State mystate;

    // Start is called before the first frame update
    void Start()
    {
        mystate = State.Done;

        switch (mystate)
        {
            case State.Done: 
                Debug.Log((int)State.Done);
                break;
            case State.WIP:
                Debug.Log((int)State.WIP);
                break;
            case State.Cancel:
                Debug.Log((int)State.Cancel);
                break;

        }

        if (mystate == State.Done)
        {
            Debug.Log((int)State.Done);
        }

        else if (mystate == State.WIP)
        {
            Debug.Log((int)State.WIP);
        }

        if ((mystate == State.Cancel);
        {
            Debug.Log((int)State.Cancel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
