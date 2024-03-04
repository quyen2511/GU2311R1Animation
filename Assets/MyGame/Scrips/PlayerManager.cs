using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Animator playerAnimator;
    private bool IsWalking = false;
    private bool IsRunning = false;
    private bool IsJumping = false;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        // Kiểm tra và cập nhật trạng thái di chuyển
        UpdateMovement();

        // Kiểm tra và cập nhật trạng thái chạy
        UpdateRunning();

        // Kiểm tra và cập nhật trạng thái nhảy
        UpdateJumping();
    }

    void UpdateMovement()
    {
        // Di chuyển trước
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            IsWalking = true;
        }
        // Di chuyển sau
        else if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            IsWalking = true;
        }
        // Di chuyển phải
        else if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            IsWalking = true;
        }
        // Di chuyển trái
        else if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            IsWalking = true;
        }
        else
        {
            IsWalking = false;
        }

        // Cập nhật trạng thái di chuyển trong Animator
        playerAnimator.SetBool("IsWalking", IsWalking);
    }

    void UpdateRunning()
    {
        // Kiểm tra và cập nhật trạng thái chạy
        if (Input.GetKey("left shift"))
        {
            IsRunning = true;
        }
        else
        {
            IsRunning = false;
        }

        // Cập nhật trạng thái chạy trong Animator
        playerAnimator.SetBool("IsRunning", IsRunning);
    }
    void UpdateJumping()
    {
        // Kiểm tra và cập nhật trạng thái chạy
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsJumping = true;
        }
        else
        {
            IsJumping = false;
        }

        // Cập nhật trạng thái chạy trong Animator
        playerAnimator.SetBool("IsJumping", IsJumping);
    }
}