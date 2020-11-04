using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodRandom : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Food;
    
    float x, y,z;
    int i = 0;



    void Start()
    {
        i++;
        {
            if (i < 5)
            {
                x = Random.Range(-140f, 140f);
                y = Random.Range(2f, 10f);
                z = Random.Range(-140f, 140f);
                
                Instantiate(Food, new Vector3(x, y, z), Quaternion.identity);               
            }
        }

    }

    // Update is called once per frame

   

}
