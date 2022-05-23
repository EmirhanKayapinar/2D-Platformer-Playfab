using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCollision : MonoBehaviour
{
    [SerializeField] GameObject _player,_object;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _player.transform.parent = gameObject.transform;
        
    }

    

    private void OnCollisionExit2D(Collision2D collision)
    {
        _player.transform.parent = _object.transform;
    }


}
