using UnityEngine;
using UnityEngine.InputSystem; // New Input System 사용

public class QueryChanController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 3.0f;
    public float jumpPower = 6.0f;

    private Vector3 direction; // Y축 속도 (점프+중력)
    private CharacterController controller;
    private Animator anim;

    [Header("Input Actions")]
    public InputAction moveAction; // 이동용
    public InputAction jumpAction; // 점프용

    void OnEnable()
    {
        moveAction.Enable();
        jumpAction.Enable();
    }

    void OnDisable()
    {
        moveAction.Disable();
        jumpAction.Disable();
    }

    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // 이동 입력
        Vector2 input = moveAction.ReadValue<Vector2>();
        Vector3 inputDirection = new Vector3(input.x, 0, input.y);

        // XZ 이동 처리
        Vector3 move = Vector3.zero;
        if (inputDirection.magnitude > 0.1f)
        {
            transform.LookAt(transform.position + inputDirection);
            move = transform.forward * speed;
            anim.SetFloat("Speed", move.magnitude);
        }
        else
        {
            anim.SetFloat("Speed", 0);
        }

        // 점프 처리
        if (jumpAction.triggered && controller.isGrounded)
        {
            direction.y = jumpPower;
            anim.SetTrigger("Jump");
        }

        // 중력 적용
        direction.y += Physics.gravity.y * Time.deltaTime;

        // 최종 이동 적용
        controller.Move((move + new Vector3(0, direction.y, 0)) * Time.deltaTime);

        // 땅에 붙으면 Y속도 초기화
        if (controller.isGrounded && direction.y < 0)
        {
            direction.y = 0;
        }
    }
}
