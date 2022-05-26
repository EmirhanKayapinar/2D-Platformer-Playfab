using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCollision : MonoBehaviour
{
    [SerializeField] Animator _anim;
    [SerializeField] GameObject _keyImage;
    [SerializeField] Text _doorText;
    [SerializeField] Collider2D _rigid;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")&& _keyImage.activeInHierarchy)
        {
            _anim.Play("Door");
            _doorText.text = "";

        }
        if (collision.gameObject.CompareTag("Player")&& _keyImage.activeInHierarchy==false)
        {
            _doorText.text = "Kapý kilitli";
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _doorText.text = "";
    }

    void isTrigger()
    {
        _rigid.isTrigger = true;
    }
}
