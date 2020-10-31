using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchport : MonoBehaviour
{
    public GameObject bullet;
    private float random;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        random = Random.Range(0,100);
        if(random <= 1)
        {
            Instantiate(bullet, this.gameObject.transform. position,this.transform.rotation);
        }
    }
}
