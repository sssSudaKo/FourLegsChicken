using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goatSim_Move : MonoBehaviour
{
    private CharacterController charaCon;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float gravity = 9.81f;

    public float speed;
    public float jumpHeight;
    public float rotSpeed;


    // Start is called before the first frame update
    void Start()
    {
        charaCon = gameObject.GetComponent<CharacterController>();　//変数charaConにCharacterController コンポネントを入れます
    }

    // Update is called once per frame
    void Update()
    {
        groundedPlayer = charaCon.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 camForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        Vector3 dir = camForward * Input.GetAxis("Vertical") + Camera.main.transform.right * Input.GetAxis("Horizontal");

        charaCon.Move(dir * Time.deltaTime * speed);

        if (dir != Vector3.zero)
        {
            Quaternion qua = Quaternion.LookRotation(dir);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, qua, rotSpeed * Time.deltaTime);
        }

        // プレイヤーのジャンプの計算
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += jumpHeight * gravity;
        }

        playerVelocity.y -= gravity * Time.deltaTime;
        charaCon.Move(playerVelocity * Time.deltaTime);

    }
}
