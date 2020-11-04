using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goatSim_Cam : MonoBehaviour
{
    public GameObject player;
    public GameObject cam;
    public float rotSpeed;

    float mX, mY;

    private float lookUpAngle;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        cam = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        rotCamAngle();
    }

    void rotCamAngle()
    {
        mX = Input.GetAxis("Mouse X");
        mY = Input.GetAxis("Mouse Y");

        lookUpAngle = Camera.main.transform.eulerAngles.x - 180 + rotSpeed * mY;
        Vector3 angle = new Vector3(mX * rotSpeed, 0, 0);

        if (Mathf.Abs(lookUpAngle) > 140)
        {
            angle.y = mY * rotSpeed;
        }

        transform.eulerAngles += new Vector3(angle.y, angle.x);
    }
}
