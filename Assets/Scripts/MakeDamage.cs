using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamage : MonoBehaviour
{
    [SerializeField] private string enemyTag = "Enemy";

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Make damage");
        if (other.gameObject.tag == enemyTag)
        {
            Debug.Log("Kill");
            Destroy(other.gameObject);
        }
    }
}
