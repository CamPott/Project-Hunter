using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_PlayerMovement : MonoBehaviour
{
    Player_Movement _MoveScript;

    // Start is called before the first frame update
    void Start()
    {
        _MoveScript = GetComponent<Player_Movement>();
    }

    public void StopPlayer()
    {
        _MoveScript.enabled = false;
    }

    public void StartPlayer()
    {
        _MoveScript.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
