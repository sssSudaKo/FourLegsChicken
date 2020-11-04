using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class APScript : MonoBehaviour
{
    //エサのスクリプト
    private static float esaPoint = 0.0f;
    private GameObject esaText0b;
    private Text esaText;
    public AudioClip EPSound;

    // Start is called before the first frame update
    void Start()
    {
        esaText0b = GameObject.Find("EP");
        esaText = esaText0b.GetComponent<Text>();
        esaPoint
             = 0;
    }

    // Update is called once per frame
    void Update()
    {
        esaText.text = "EP : " + esaPoint;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Esa"))
        {
            AudioSource sound2 = GetComponent<AudioSource>();
            sound2.PlayOneShot(EPSound);
            esaPoint++;
            other.gameObject.SetActive(false);

        }
        if (other.gameObject.CompareTag("BigEsa"))
        {
            AudioSource sound2 = GetComponent<AudioSource>();
            sound2.PlayOneShot(EPSound);
            esaPoint+=5;
            other.gameObject.SetActive(false);

        }
    }
    public static float EsaPGetter()
    {
        return esaPoint;
    }
}
