using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMove : MonoBehaviour
{
    public GameObject pipes;

    void Update()
    {
        pipes.transform.position = transform.position + new Vector3(-0.025f, 0, 0);
    }
}
