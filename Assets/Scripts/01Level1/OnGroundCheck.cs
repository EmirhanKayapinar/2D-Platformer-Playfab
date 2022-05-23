using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGroundCheck : MonoBehaviour
{
    [SerializeField] Transform[] _transforms;
    [SerializeField] float _maxDistance;
    [SerializeField] bool _isOnGround=false;
    [SerializeField] LayerMask _layermask;
    [SerializeField] Animator _anim;
    public bool _OnGround => _isOnGround;
    public void OnGround(Transform _transform)
    {
        RaycastHit2D hit = Physics2D.Raycast(_transform.position, _transform.forward, _maxDistance, _layermask);
        Debug.DrawRay(_transform.position, _transform.forward * _maxDistance, Color.red);

        if (hit.collider != null)
        {
            _isOnGround = true;
            _anim.SetBool("__isJump", false);
        }
        else
        {
            _isOnGround = false;
            _anim.SetBool("__isJump", true); 
        }
    }
    private void Update()
    {
        foreach (Transform _transform in _transforms)
        {
            OnGround(_transform);
            if (_isOnGround)
            {
                break;
            }
        }
    }


}
