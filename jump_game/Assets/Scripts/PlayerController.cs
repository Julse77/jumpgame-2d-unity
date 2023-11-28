using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform PlayerTransform;
    private Rigidbody2D PlayerRigidbody;
    private float MoveSpeed = 0.1f;
    private float JumpHeight = 5.0f;
    private Vector2 MovePosition;
    private Vector2 CurPosition;

    private void Start()
    {
        PlayerTransform = GetComponent<Transform>();
        PlayerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        PlayerMove();
        PlayerJump();
    }

    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            PlayerTransform.rotation = new Quaternion(0, 180, 0, 0);
            MovePosition = new Vector2(MoveSpeed, 0f);
            CurPosition = PlayerRigidbody.position + MovePosition;
            PlayerRigidbody.MovePosition(CurPosition);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            PlayerTransform.rotation = new Quaternion(0, 0, 0, 0);
            MovePosition = new Vector2(-MoveSpeed, 0f);
            CurPosition = PlayerRigidbody.position + MovePosition;
            PlayerRigidbody.MovePosition(CurPosition);
        }
    }

    private void PlayerJump()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            PlayerRigidbody.velocity = new Vector2(PlayerRigidbody.velocity.x, JumpHeight);
        }
    }

}
