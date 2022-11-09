using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField]
    Transform _target;

    [SerializeField]
    float _smoothSpeed;

    Vector3 _offset;



    private void Start()
    {
        _offset = transform.position - _target.position;
    }

    private void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, _offset + _target.position, _smoothSpeed);
        transform.position = newPos;
    }








}
