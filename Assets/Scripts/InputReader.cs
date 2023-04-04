using Player;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private PlayerEntity _playerEntity;

    private float _horizontalDirection;
    private float _verticalDirection;
    
    private void Update()
    {
        _horizontalDirection = Input.GetAxisRaw("Horizontal");
        _verticalDirection = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            _playerEntity.Jump();
            _animator.SetBool("_isJumping", true);
        }
    }

    private void FixedUpdate()
    {
        _playerEntity.MoveHorizontally(_horizontalDirection);
        _playerEntity.MoveVertically(_verticalDirection);
    }
}