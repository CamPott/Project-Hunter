using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Up : MonoBehaviour
{
    public GameObject _PickUp_Object;
    public GameObject _DialogueFlow;

    

    private void OnTriggerStay (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("Collected");
                _DialogueFlow.SetActive(true);
                _PickUp_Object.SetActive(false);

                

                Cursor.lockState = CursorLockMode.Confined;
            }

        }
    }
}
