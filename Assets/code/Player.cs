using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float scrool = -0.5f;
    public float rotation = 0;
    public float thrust = 5f;

    public GameObject ground;
    public Rigidbody2D player;

    public AudioSource Flap; 

    void Update()
    {
        scrool = scrool - 0.013f;

        ground.transform.position = new Vector3(scrool, 0, 0);

        if (scrool < -24.5f)
        {
            scrool = 0f;
        }

        if (Input.GetKeyDown("space"))
        {
            player.velocity = new Vector2(0.0f, thrust);
            player.transform.eulerAngles = new Vector3(0f, 0f, 15f);
            Flap.Play(0);
        }

        player.transform.Rotate(0.0f, 0.0f, -0.2f, Space.World);
    }
}
