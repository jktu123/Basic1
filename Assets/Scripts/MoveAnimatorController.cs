using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

namespace Animations
{
    public class MoveAnimatorController : MonoBehaviour
    {
        private Animator _animator;
        private bool _isDie;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                _animator.SetTrigger("Jump");
            }

            if(Input.GetKeyDown(KeyCode.A))
            {
                _animator.SetTrigger("TurnLeft");
            }

            if(Input.GetKeyDown(KeyCode.D))
            {
                _animator.SetTrigger("TurnRight");
            }

            if(Input.GetKeyDown(KeyCode.I))
            {
                _animator.SetBool("IsDie", true);
            }
            if(Input.GetKeyDown(KeyCode.U))
            {
                _animator.SetBool("IsDie", false);
            }
        }

  

    }

}
