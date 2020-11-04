using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutterSub : MonoBehaviour
{
    public float timer = 0.0f;
    public GameObject CutterPrefab;
    private float downforce = -70.0f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= 2.0f)
        {
            rb.AddForce(transform.forward * downforce);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            timer = 0.0f;
        }
    }
}
