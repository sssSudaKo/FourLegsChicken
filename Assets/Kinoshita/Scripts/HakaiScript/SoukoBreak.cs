using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoukoBreak : MonoBehaviour
{
    public GameObject BreakEffect;
    public float Torque;
    public float Power;
    public AudioClip AttackSound, ExplosionSound, BreakSound;
    private float HP = 600;
    private float DamageCount;
    bool Bung = false;
    GameObject Score;

    // 自身の子要素を管理するリスト
    List<GameObject> myParts = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // 自分の子要素をチェック
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.AddComponent<Rigidbody>();
            child.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            // 子要素リストにパーツを追加
            myParts.Add(child.gameObject);

        }
        DamageCount = 0;
        Score = GameObject.Find("Text");//スクリプトを参照　　""の中はスコア表示のテキスト名
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= DamageCount)//ダメージがHPを超えると破壊
        {
            Bung = true;
        }
        else
        {
            Bung = false;
        }

        if (Bung == true)
        {
            Explode();
            Instantiate(BreakEffect, transform.position, Quaternion.identity);　//エフェクト発生
            Score.GetComponent<Score>().GetHouse();//Scoreのメソッド実行
            DamageCount = 0;

            //サウンド再生
            AudioSource sound1 = GetComponent<AudioSource>();
            sound1.PlayOneShot(AttackSound);
            AudioSource sound2 = GetComponent<AudioSource>();
            sound2.PlayOneShot(ExplosionSound);
            AudioSource sound3 = GetComponent<AudioSource>();
            sound3.PlayOneShot(BreakSound);

            var DestroyGameObject = gameObject.GetComponent<BoxCollider>();　　//BoxCollider削除用インスタンス作成
            Destroy(DestroyGameObject);　　//BoxCollider削除
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //キックダメージ
        if (other.gameObject.name == "KickCollision")
        {
            DamageCount += 150;
            Shake(0.25f, 0.1f);
        }

        //ブラストダメージ
        if (other.gameObject.name == "Sphere(Clone)")
        {
            DamageCount += 110;
            Shake(0.25f, 0.1f);
        }

        //カッターダメージ
        if (other.gameObject.name == "Cutter(Clone)")
        {
            DamageCount += 70;
            Shake(0.25f, 0.1f);
        }
    }




    // 吹き飛ばしメソッド
    void Explode()
    {
        foreach (GameObject obj in myParts)
        {
            Vector3 forcePower = new Vector3(Random.Range(Power, Power), Random.Range(-Power * 0.5f, Power * 0.5f), Random.Range(-Power * 0.5f, Power * 0.5f));
            Vector3 TorquePower = new Vector3(Random.Range(-Torque, Torque), Random.Range(-Torque, Torque), Random.Range(-Torque, Torque));

            obj.GetComponent<Rigidbody>().isKinematic = false;
            obj.GetComponent<Rigidbody>().AddForce(forcePower, ForceMode.Impulse);
            obj.GetComponent<Rigidbody>().AddTorque(TorquePower, ForceMode.Impulse);
            //5秒後に消す
            Destroy(gameObject, 5.0f);
        }
    }
    //揺らすメソッド
    public void Shake(float duration, float magnitude)
    {
        StartCoroutine(DoShake(duration, magnitude));
    }

    private IEnumerator DoShake(float duration, float magnitude)
    {
        var pos = transform.localPosition;

        var elapsed = 0f;

        while (elapsed < duration)
        {
            var x = pos.x + Random.Range(-1f, 1f) * magnitude;
            var y = pos.y + Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, pos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = pos;
    }
}
