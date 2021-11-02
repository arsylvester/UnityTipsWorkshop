using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NamespaceExample
{
    public class SingletonExample : MonoBehaviour
    {
        public static SingletonExample _instance;

        void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            }
            else
            {
                _instance = this;
            }

            DontDestroyOnLoad(gameObject);
        }

        public void NamespaceExampleFunction()
        {
            print("Namespaces are cool.");
        }
    }
}
