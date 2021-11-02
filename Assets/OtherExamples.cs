using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherExamples : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "Player")
        {
            //Do something
        }

        if (gameObject.layer == 2)
        {
            //do something
        }

        //Use layers to ignore or only find objects on a layer with a raycast.
        int layermask = 1 << 5; //Only layer 5
        layermask = ~layermask; //All but layer 5

        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.forward, out hit, Mathf.Infinity, layermask))
        {
            //Do something with raycast
        }

        float tempSpeed = moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * tempSpeed);
    }
}
