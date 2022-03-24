using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face_Player : MonoBehaviour
{
    public GameObject _Player;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(_Player.transform);
    }
}
