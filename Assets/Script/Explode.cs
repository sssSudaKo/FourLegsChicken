using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    // 自身の子要素を管理するリスト
    List<GameObject> myParts = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // 自分の子要素をチェック
        foreach (Transform child in gameObject.transform)
        {

            // ビルパーツに Rigidbody2D を追加して Kinematic にしておく
            child.gameObject.AddComponent<Rigidbody>();
            child.gameObject.GetComponent<Rigidbody>().isKinematic = true;

            // 子要素リストにパーツを追加
            myParts.Add(child.gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ExplodeM();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            ExplodeM();
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag=="Player")
        {
            ExplodeM();
        }
    }



    void ExplodeM()
    {

        // 各パーツをふっとばす
        foreach (GameObject obj in myParts)
        {

            // 飛ばすパワーと回転をランダムに設定
            Vector3 forcePower = new Vector3(Random.Range(-30, 30), Random.Range(-30, 30),Random.Range(-30,30));
      

            // パーツをふっとばす！
            obj.GetComponent<Rigidbody>().isKinematic = false;
            obj.GetComponent<Rigidbody>().AddForce(forcePower, ForceMode.Impulse);
        }
    }
}
