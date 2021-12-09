using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject Tuyaux;
    public float height;

    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newTuyaux = Instantiate(Tuyaux);
            newTuyaux.transform.position =  new Vector3(4, Random.Range(-height, height), 0);
            Destroy(newTuyaux, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
