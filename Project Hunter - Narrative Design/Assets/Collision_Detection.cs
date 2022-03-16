using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Detection : MonoBehaviour
{
    public Weapon_Controller wc;
    public GameObject _HitParticle;
    public GameObject _Enemy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && wc.IsAttacking)
        {
            Debug.Log(other.name);
            other.GetComponent<Animator>().SetTrigger("Hit");

            Instantiate(_HitParticle, new Vector3(other.transform.position.x,
                transform.position.y, other.transform.position.z),
                other.transform.rotation);
            Destroy(_Enemy);
        }
    }
}
