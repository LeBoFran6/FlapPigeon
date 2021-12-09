using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCounter : MonoBehaviour
{
    public increaseScore score;

    public AudioSource ScoreUp;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            score.augmenterScore();
            ScoreUp.Play(0);
        }
    }
}
