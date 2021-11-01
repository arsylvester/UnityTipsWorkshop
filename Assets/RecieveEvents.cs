using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecieveEvents : MonoBehaviour
{
    private void OnEnable()
    {
        //TestingEvents.OnTestEvent += OnEventBeenRecieved;
    }

    private void OnDisable()
    {
        //TestingEvents.OnTestEvent -= OnEventBeenRecieved;
    }

    public void OnEventBeenRecieved()
    {
        print("Event Recieved!");
    }
}
