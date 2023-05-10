using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForObjects : MonoBehaviour
{
    private float stepOffset;
    [SerializeField] private CharacterController characterController;
    void Start()
    {
        stepOffset = characterController.stepOffset;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Rigidbody>() != null)
        {
            characterController.stepOffset = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Rigidbody>() != null)
        {
            characterController.stepOffset = stepOffset;
        }
    }
}
