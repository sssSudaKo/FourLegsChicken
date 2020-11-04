using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
    public GameObject playerModel1, playerModel2, playerModel3, playerModel4;
    public GameObject Effect1, Effect2, Effect3;
    private float esaP;
    // Start is called before the first frame update
    void Start()
    {
        playerModel1.SetActive(true);
        playerModel2.SetActive(false);
        playerModel3.SetActive(false);
        Effect1.SetActive(false);
        Effect2.SetActive(false);
        Effect3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        esaP = APScript.EsaPGetter(); 
        //取った時に変わる個数
        if(esaP < 20 && esaP >= 10)
        {
            playerModel1.SetActive(false);
            playerModel2.SetActive(true);
            playerModel3.SetActive(false);
            playerModel4.SetActive(false);
            Effect1.SetActive(true);
            Destroy(Effect1, 1f);
        }
        if(esaP < 30 && esaP >= 20)
        {
            playerModel1.SetActive(false);
            playerModel2.SetActive(false);
            playerModel3.SetActive(true);
            playerModel4.SetActive(false);
            Effect2.SetActive(true);
            Destroy(Effect2, 1f);
        }
        if (esaP >= 45)
        {
            playerModel1.SetActive(false);
            playerModel2.SetActive(false);
            playerModel3.SetActive(false);
            playerModel4.SetActive(true);
            Effect3.SetActive(true);
            Destroy(Effect3, 1f);
        }
    }
}
