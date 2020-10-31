using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject prefab;
    private bool flag = true;
    private float pullTime = 0.0f;
    public AudioClip BlustSound;
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            pullTime += 1.0f;
        }
        if (flag == true && pullTime >= 120)
        {
            StartCoroutine(CreateWave());
            flag = false;
            pullTime = 0.0f;
        }

    }
    IEnumerator CreateWave()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
            AudioSource sound1 = GetComponent<AudioSource>();
            sound1.PlayOneShot(BlustSound);
            yield return new WaitForSeconds(1);
        }
        flag = true;
        yield break;
    }
}