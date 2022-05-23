using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    MoverController _mover;
    [SerializeField] Transform _playerTransform;
    [SerializeField] float _hSpeed, _vSpeed, _jSpeed;
    [SerializeField] bool _isHorizontalActive, _isJumpActive, _isFlipActive;
    public bool _isVerticalActive;
    [SerializeField] SpriteRenderer _playerSprite;
    [SerializeField] Rigidbody2D _playerRigid;
    [SerializeField] Animator _anim;
    bool _spaceControl;
    private void Awake()
    {
        _mover = new MoverController();
    }

    void Horizontal()
    {
        _mover.HorizontalMove(_playerTransform,_hSpeed,_isHorizontalActive,_anim);
    }

    void Vertical()
    {
        _mover.VerticalMove(_playerTransform, _vSpeed, _isVerticalActive);
    }

    void Jump()
    {
        switch (_spaceControl)
        {
            case true:
                _mover.JumpMove(_playerRigid, _jSpeed, _isJumpActive);
                break;
            
        }

        _spaceControl = false;
    }
    void Flip()
    {
        _mover.Flip(_playerSprite, _isFlipActive);
    }

    private void FixedUpdate()
    {
        Horizontal();
        Vertical();
        Flip();
        Jump();
    }
    void Start()
    {
        
    }

    void Update()
    {
        switch (Input.GetKeyDown(KeyCode.Space))
        {
            case true:
                _spaceControl = true;
                break;
        }
    }
}
