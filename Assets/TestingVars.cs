using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TestingVars : MonoBehaviour
{
    #region Variables
    [Header("Test Header")]

    [Tooltip("This is a tooltip that can give a neat little description of this variable.")]
    [Range(0, 10)]
    [SerializeField]
    private float testFloat = 9f;

    [SerializeField] private string descOfBool = "";
    [SerializeField] private bool testBool = false;

    private AudioSource audioSource;
    #endregion

    #region Functions
    // Start is called before the first frame update
    void Start()
    {
        //Shouldn't have to null check since we have the RequireComponent
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        descOfBool = testBool ? "Bool is true." : "Bool is false.";
    }
    #endregion
}
