using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Talk : MonoBehaviour
{
    public GameObject _DiaogueFlow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
       if (other.CompareTag("Player_Face"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("In Range");
                _DiaogueFlow.SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;
            }
            
        }
    }
}
