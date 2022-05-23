using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverController : IMove
{
    public float Horizontal => Input.GetAxis("Horizontal")*Time.deltaTime;

    public float Vertical => Input.GetAxis("Vertical") * Time.deltaTime;

    public float Jump => Input.GetAxis("Jump") ;



    public void HorizontalMove(Transform _transform, float _hSpeed,bool _isHorizontalActive, Animator _anim)
    {
        switch (_isHorizontalActive)
        {
            case true:
                _transform.position += new Vector3(Horizontal * _hSpeed, 0);
                _anim.SetFloat("__isWalk", Mathf.Abs(Input.GetAxis("Horizontal")));
                break;
            default:
                _isHorizontalActive = false;
                break;
        }
    }

    public void VerticalMove(Transform _transform, float _vSpeed, bool _isVerticalActive)
    {
        switch (_isVerticalActive)
        {
            case true:
                _transform.position += new Vector3(0, Vertical * _vSpeed);
                break;
            default:
                _isVerticalActive = false;
                break;
        }
    }

    public void JumpMove(Rigidbody2D _rigid, float _jSpeed,bool _isJumpActive )
    {
        switch (_isJumpActive)
        {
            case true:
                _rigid.AddForce(Vector2.up * Jump * _jSpeed);
                break;
            default:
                _isJumpActive = false;
                break;
        }
    }

    public void Flip(SpriteRenderer _sprite, bool _isFlipActive)
    {
        switch (_isFlipActive && Horizontal > 0)
        {
            case true:
                _sprite.flipX = false;
                break;
           
        }

        switch (_isFlipActive && Horizontal < 0)
        {
            case true:
                _sprite.flipX = true;
                break;
        }
    }


}
