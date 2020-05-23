using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public GameObject explosionFX;
    public GameObject spawner, GameOverPanel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bomb"))
        {
            spawner.SetActive(false);
            GameOverPanel.SetActive(true);
            Debug.Log("GameOver");
            Instantiate(explosionFX, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);            
        }
    }
}
