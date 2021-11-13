using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingFunctions : MonoBehaviour
{
    [SerializeField] bool update = false;
    [SerializeField] bool fixedUpdate = false;
    [SerializeField] bool lateUpdate = false;
    [SerializeField] bool onEnable = false;
    [SerializeField] bool onTriggerStay = false;
    [SerializeField] bool onTriggerExit = false;

    void Start()
    {
        print("Start");
    }

    private void Awake()
    {
        print("Awake");
    }

    private void OnEnable()
    {
        if (onEnable) print("On Enable");
    }

    private void OnDisable()
    {
        print("On Disable");
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
        if(onTriggerExit) print("Trigger Exit with " + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        if(onTriggerStay) print("Trigger Stay with " + other.gameObject.name);
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
