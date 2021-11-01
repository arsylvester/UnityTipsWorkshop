using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestingEvents : MonoBehaviour
{
    public UnityEvent TriggerEntered;

    public delegate void TestAction();
    public static event TestAction OnTestEvent;

    private void OnTriggerEnter(Collider other)
    {
        TriggerEntered.Invoke();
        //OnTestEvent();
    }
}
