using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Controller : MonoBehaviour
{
    public GameObject _Sword;
    public bool CanAttack = true;
    public float AttackCooldown = 1.0f;
    public AudioClip _SwordSlashSFX;
    public bool IsAttacking = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (CanAttack)
            {
                SwordAttack();
            }
        }
    }

    public void SwordAttack()
    {
        IsAttacking = true;
        CanAttack = false;

        Animator anim = _Sword.GetComponent<Animator>();
        anim.SetTrigger("Attack");

        AudioSource ac = GetComponent<AudioSource>();
        ac.PlayOneShot(_SwordSlashSFX);

        StartCoroutine(ResetAttackCooldown());
    }

    IEnumerator ResetAttackCooldown()
    {
        StartCoroutine(ResetAttackBool());
        yield return new WaitForSeconds(AttackCooldown);
        CanAttack = true;
    }

    IEnumerator ResetAttackBool()
    {
        yield return new WaitForSeconds(1.0f);
        IsAttacking = false;
    }
}
