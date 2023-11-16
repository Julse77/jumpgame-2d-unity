using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform PlayerTransform;
    public Rigidbody2D PlayerRigidbody;
    private float moveSpeed = 0.1f;
    // private float jumpHeight = 0.4f;

    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            PlayerTransform.rotation = new Quaternion(0, 180, 0, 0);
            Vector2 movePosition = new Vector2(moveSpeed, 0f);
            Vector2 curPostion = PlayerRigidbody.position + movePosition;
            PlayerRigidbody.MovePosition(curPostion);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            PlayerTransform.rotation = new Quaternion(0, 0, 0, 0);
            Vector2 movePosition = new Vector2(-moveSpeed, 0f);
            Vector2 curPostion = PlayerRigidbody.position + movePosition;
            PlayerRigidbody.MovePosition(curPostion);
        }
    }


}
