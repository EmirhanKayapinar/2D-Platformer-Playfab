using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollision : MonoBehaviour
{
    GameObject _main;
    private void Awake()
    {
        _main = GameObject.FindGameObjectWithTag("Main");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _main.GetComponent<Score>()._scores += 100;
            Destroy(gameObject);

        }
    }
}
