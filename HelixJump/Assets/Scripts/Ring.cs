using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    [SerializeField]
    Transform ball;

    GameManager gm;

    private void Start()
    {
        gm = GameManager.FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (transform.position.y + 10f >= ball.position.y)
        {
            gm.GameScore(25);
            Destroy(gameObject);  
        }
    }
}
