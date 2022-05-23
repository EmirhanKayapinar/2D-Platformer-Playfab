using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderCollision : MonoBehaviour
{
    [SerializeField] Animator _anim;
    [SerializeField] Rigidbody2D _player;
    bool climb,_ladder;
    [SerializeField] GameObject _playerObject;
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (_ladder)
        {
            _playerObject.GetComponent<PlayerController>()._isVerticalActive = true;
            if (collision.gameObject.CompareTag("Player"))
            {
                _anim.SetBool("__isClimb", true);
                _player.gravityScale = 0;
                _anim.SetBool("__isJump", false);
                _player.constraints = RigidbodyConstraints2D.FreezePositionY;
                if (climb)
                {
                    _anim.speed = 1;
                    _player.constraints = RigidbodyConstraints2D.None;
                }

                else
                {
                    _anim.speed = 0;
                    _player.constraints = RigidbodyConstraints2D.None;
                }
            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _anim.SetBool("__isClimb", false);
        _anim.SetBool("__isJump", true);
        _player.gravityScale = 1;
        _player.constraints = RigidbodyConstraints2D.None;
        _anim.speed = 1;
        _playerObject.GetComponent<PlayerController>()._isVerticalActive = false;
        _ladder = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.S))
        {
            climb = true;
            _ladder = true;
        }

        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            climb = false;
        }
        
    }
}
