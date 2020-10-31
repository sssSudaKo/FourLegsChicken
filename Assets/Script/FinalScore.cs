using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public GameObject Text;

    public Text title;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int num = Text.GetComponent<Score>().ScorePoint;
        title.text = "Score : " + num;
    }
}
