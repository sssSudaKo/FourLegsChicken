using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
    public GameObject CutterPrefab;
    public AudioClip CutterSound;
    private float timer = 0.0f;
    private float timeBetweenShot = 3.5f;
    private float power = 1000.0f;
    private float modoru;
    

    void FixedUpdate()
    {
        timer += Time.deltaTime;
        // もしもJキーを押したならば（条件）
        if (Input.GetKeyDown(KeyCode.J) && timer > timeBetweenShot)
        {
            timer = 0.0f;
            GameObject Cutter = Instantiate(CutterPrefab, transform.position, Quaternion.Euler(0,0,45));
            Rigidbody CutterRb = Cutter.GetComponent<Rigidbody>();
            CutterRb.AddForce(transform.forward * power);

            // 発射したカッターを4秒後に破壊する。
            Destroy(Cutter, 3.4f);

            //カッター射出時の音
            AudioSource sound1 = GetComponent<AudioSource>();
            sound1.PlayOneShot(CutterSound);
        }

    }
}
