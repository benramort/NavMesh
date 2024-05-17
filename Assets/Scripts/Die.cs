using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private string enemyTag;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión");
        if (collision.collider.gameObject.tag == enemyTag)
        {
            Debug.Log("A respawnear");
            this.GetComponent<PlayerNavigate>().Respawn(respawnPoint.position);
        }   
    }
}
