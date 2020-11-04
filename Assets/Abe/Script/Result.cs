using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    public GameObject ResultPanel;
    public GameObject ScoreText;


    /*
    GameObject Time;   時間制御してるスクリプトを貼ってるオブジェクト(今回はTextかな？)
    GameObject HP;　　 HPを制御してるスクリプトを貼ってるオブジェクト(今回はTextかな？)

    TimeScrip Tscrip;　
    　↑時間制御してるスクリプトの名前

    HPScript HScript;
      ↑時間制御してるスクリプトの名前
    */




    // Start is called before the first frame update
    /*
    private void Awake()
    {

    }
    */
    void Start()
    {
        ResultPanel = GameObject.Find("ResultPanel");
        ResultPanel.SetActive(false);
        ScoreText = GameObject.Find("Score");
        /*
        Time = GameObject.Find("");
        HP = GameObject.Find("HP");

        Tscrip = GetComponent<TimeText>();
        HScript = GetComponent<HPscript>();
        */
    }

    // Update is called once per frame
    void Update()
    {
        /*
        int time = Tscript.Time;
        int HP = HScript.HP;

        if(time==0||HP==0)
        {
            ResultPanel.SetActive(true);
        }
        */
       
    }
}
