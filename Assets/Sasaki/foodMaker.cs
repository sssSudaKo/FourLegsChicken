using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodMaker : MonoBehaviour
{
    public GameObject food;
    public int amountOfFood;

    float x, y, z;
    void Start()
    {
        for(int i = 0; i < amountOfFood; i++)
        {
            x = Random.Range(-140f, 140f);
            y = Random.Range(2f, 10f);
            z = Random.Range(-140f, 140f);

            Instantiate(food, new Vector3(x, y, z), Quaternion.identity);
        }
    }
}
