using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandıkCollision : MonoBehaviour
{
    bool fControl;
    [SerializeField] Animator _anim,keyAnim;
    [SerializeField] GameObject key;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _anim.Play("sandık");
            Debug.Log("calisti");
            
        }
    }
   
    private void Update()
    {
       
    }

    public void Destroy()
    {
        gameObject.SetActive(false);
    }

    public void Keyanim()
    {
        key.SetActive(true);
        keyAnim.Play("Key");
    }
}
