using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float horizontalSpeed = 100f;
    [SerializeField] float verticalSpeed = 10f;
    [SerializeField] private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        float v = verticalSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(0, 0, v);
        transform.Rotate(0, h, 0);
        _anim.SetFloat("IsWalking",Mathf.Abs(v));
    }
}