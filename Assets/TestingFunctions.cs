using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingFunctions : MonoBehaviour
{
    [SerializeField] bool update = false;
    [SerializeField] bool fixedUpdate = false;
    [SerializeField] bool lateUpdate = false;

    void Start()
    {
        print("Start");
    }

    private void Awake()
    {
        print("Awake");
    }

    void Update()
    {
        if(update) print("Update");
    }

    private void FixedUpdate()
    {
        if(fixedUpdate) print("Fixed Update");
    }

    private void LateUpdate()
    {
        if(lateUpdate) print("Late Update");
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Collision with " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Trigger Enter with " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        print("Trigger Exit with " + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        print("Trigger Stay with " + other.gameObject.name);
    }

    private void OnDestroy()
    {
        print(gameObject.name + " has been destroyed!");
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        //Gizmos.DrawSphere(transform.position, 5f);
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }
}
