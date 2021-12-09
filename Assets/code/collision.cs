using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject gameOver;

    public AudioSource PigeonDie;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Player>() != null)
        {
            collision.gameObject.SetActive(false);
            gameOver.SetActive(true);
            PigeonDie.Play(0);
        }
    }
}
