using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{
    GameObject FirstChicken;
    GameObject SecondChicken;
    GameObject ThirdChicken;
    GameObject FinalChicken;
    public int FirstEvo = 100;
    public int SecondEvo = 200;
    public int ThirdEvo = 300;
    public int ScorePoint;

    // Start is called before the first frame update
    void Start()
    {
        this.FirstChicken = GameObject.Find("1stChicken");
        this.SecondChicken = GameObject.Find("2ndChicken");
        this.ThirdChicken = GameObject.Find("3rdChicken");
        this.FinalChicken = GameObject.Find("FinalChicken");
    }

    void Change()
    {
        FirstChicken.SetActive(true);
        SecondChicken.SetActive(false);
        ThirdChicken.SetActive(false);
        FinalChicken.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ScorePoint >= FirstEvo)
        {
            FirstChicken.SetActive(false);
            SecondChicken.SetActive(true);
        }
        if (ScorePoint >= SecondEvo)
        {
            SecondChicken.SetActive(false);
            ThirdChicken.SetActive(true);
        }
        if (ScorePoint >= ThirdEvo)
        {
            ThirdChicken.SetActive(false);
            FinalChicken.SetActive(true);
        }
    }
}