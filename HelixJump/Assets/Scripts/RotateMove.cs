using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMove : MonoBehaviour
{

    [SerializeField]
    float _rotateSpeed;
    float _moveX;

    private void Update()
    {
        _moveX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f, _moveX * _rotateSpeed * Time.deltaTime, 0f);
        }
    }







}
