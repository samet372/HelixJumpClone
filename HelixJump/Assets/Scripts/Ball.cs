using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody _rigidbody;

    [SerializeField]
    float _jumForce;

    [SerializeField]
    GameObject _splashPrefab;

    GameManager gm;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        gm = GameManager.FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _rigidbody.AddForce(Vector3.up * _jumForce);

        GameObject splash = Instantiate(_splashPrefab, transform.position + new Vector3(0f, -0.23f, 0f), transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;




        if (materialName == "SafeColor (Instance)")
        {
            //puan al

        }
        else if (materialName == "UnsafeColor (Instance)")
        {
            gm.RestartGame();

        }
        else if (materialName == "LastRing (Instance)")
        {
            
            //level sonu
        }

    }


}
