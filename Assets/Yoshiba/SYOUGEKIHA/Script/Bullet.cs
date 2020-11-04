using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DesBullet", 5);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += transform.forward;
    }
    void DesBullet()
    {
        Destroy(this.gameObject);
    }
}
