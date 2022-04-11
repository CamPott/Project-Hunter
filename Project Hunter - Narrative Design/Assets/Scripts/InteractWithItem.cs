using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithItem : MonoBehaviour
{
    
    public GameObject _DialogueFlow;



    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("Collected");
                _DialogueFlow.SetActive(true);
                



                Cursor.lockState = CursorLockMode.Confined;
            }

        }
    }
}
