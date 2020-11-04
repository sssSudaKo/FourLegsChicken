using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstSpark : MonoBehaviour
{
    public GameObject burst_spark;//Particleを宣言

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(burst_spark, transform.position, transform.rotation);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        //衝突したオブジェクトがSphereだったらParticleを発生させる
        if (other.gameObject.name == "Cube")
        {
            Instantiate(burst_spark, transform.position, transform.rotation);
        }
    }
}
