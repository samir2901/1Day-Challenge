using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    public GameObject explosionFX;
    public AudioSource sound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        sound.Play();
        if (collision.gameObject.CompareTag("Ground"))
        {            
            Instantiate(explosionFX, transform.position, Quaternion.identity);                            
            Destroy(gameObject);
        }
    }
}
