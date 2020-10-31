using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeCount = 0.0f;
    public float timer = 180;
    public GameObject timerTextOb, ResultPanel, Fade;
    private Text timerText;
        // Start is called before the first frame update
    void Start()
    {
        timerText = timerTextOb.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeCount++;
        if(timeCount % 60 == 0)
        {
            timer--;
        }
        timerText.text = "Time : " + timer;

        if (timer <= 0)
        {
            ResultPanel.SetActive(true);
            Fade.SetActive(false);
        }
    }
}
