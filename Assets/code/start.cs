using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject player;
    public GameObject pipes;
    public GameObject spawner;

    private void Start()
    {
        Screen.SetResolution(750, 1334, true);
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            player.SetActive(true);
            startScreen.SetActive(false);
            pipes.SetActive(true);
            spawner.SetActive(true);
        }
    }
}
