using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPScript : MonoBehaviour
{
    public GameObject HitEffect, ResultPanel, Fade;

    private static float HPPoint = 50.0f;
    private GameObject HPText0b;
    private Text HPText;
    public AudioClip Sound;
    // Start is called before the first frame update
    void Start()
    {
        HPPoint = 50.0f;
        HPText0b = GameObject.Find("HP");
        HPText = HPText0b.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HPText.text = "HP : " + HPPoint;

        if (HPPoint <= 0)
        {
            ResultPanel.SetActive(true);
            Fade.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            HPPoint--;
            other.gameObject.SetActive(false);
        }
        if(other.gameObject.CompareTag("Bullet"))
        {
            HPPoint-=5;
            Destroy(other.gameObject);
            Instantiate(HitEffect, transform.position, Quaternion.identity);　//エフェクト発生

            AudioSource sound1 = GetComponent<AudioSource>();
            sound1.PlayOneShot(Sound);

            Destroy(HitEffect, 1.0f);
        }
    }
    public static float HPGetter()
    {
        return HPPoint;
    }
}
