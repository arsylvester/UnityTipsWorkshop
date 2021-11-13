using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingCoroutines : MonoBehaviour
{
    [SerializeField] bool waitFor = false;
    [SerializeField] bool runForeverCoroutine = false;
    [SerializeField] bool stopCoroutine = false;
    private Coroutine foreverCoroutine;

    void Start()
    {
        StartCoroutine(WaitExampleCoroutine());
        //ShowPrivateCoroutine();
        if(runForeverCoroutine) foreverCoroutine = StartCoroutine(WaitForever());
    }

    void Update()
    {
        if (stopCoroutine)
        {
            StopCoroutine(foreverCoroutine);
            //StopAllCoroutines();
        }
    }

    IEnumerator WaitExampleCoroutine()
    {
        yield return new WaitForEndOfFrame();
        print("End Of Frame");
        yield return new WaitForFixedUpdate();
        print("End Of Fixed Update");
        yield return new WaitForSeconds(5f);
        print("5 scaled seconds has passed");
        yield return new WaitForSecondsRealtime(5f);
        print("5 unscaled seconds has passed");
        yield return new WaitUntil(() => waitFor);
        print("Bool was set true");
        yield return new WaitWhile(() => waitFor);
        print("Bool was set false");
    }

    IEnumerator WaitForever()
    {
        while(true)
        {
            print("I WILL PRINT FOREVER!");
            yield return new WaitForEndOfFrame();
        }
    }

    private void ShowPrivateCoroutine()
    {
        string valueToPass = " with a passed in value";
        StartCoroutine(MyPrivateCoroutine(valueToPass));

        IEnumerator MyPrivateCoroutine(string value)
        {
            yield return new WaitForEndOfFrame();
            print("Private coroutine" + valueToPass);
        }
    }
}
