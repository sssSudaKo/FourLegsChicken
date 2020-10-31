using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        player = GameObject.FindGameObjectWithTag("Player");
　　　  Invoke("BrokeWave", 0.8f);
    }
    void Update()
    {
        transform.localScale += new Vector3(1.0f, 1.0f, 1.0f);
        this.transform.position = player.transform.position;
    }
    void BrokeWave()
    {
        Destroy(this.gameObject);
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") == false)
        {
           // Destroy(other.gameObject);
            //Destroy(this.gameObject);
        }
    }
    
}