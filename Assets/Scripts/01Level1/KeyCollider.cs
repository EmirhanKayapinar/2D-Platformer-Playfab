using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollider : MonoBehaviour
{
    [SerializeField] GameObject _keyImage;
    [SerializeField] GameObject _sandik;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && _sandik.activeInHierarchy == false)
        {
            Destroy(gameObject);
            _keyImage.SetActive(true);

        }
    }
}
