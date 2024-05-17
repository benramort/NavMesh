using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private GameObject damageZone;
    [SerializeField] private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) 
        {
            StartCoroutine(AttackSword());
        }
    }

    private IEnumerator AttackSword()
    {
        animator.SetTrigger("Attack 02");
        yield return new WaitForSeconds(0.2f);
        damageZone.SetActive(true);
        //Debug.Log("Hola");
        yield return new WaitForSeconds(0.1f);
        damageZone.SetActive(false);
    }
}
