using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Rigidbody2D _rigidbody;
    private const string AstroWalk = "Walk";
    private const string AstroJump = "Jump";

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            _animator.Play(AstroWalk);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            _animator.Play(AstroWalk);
        }

        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(Vector2.up * _jumpForce);
            _animator.Play(AstroJump);
        }
    }
}
