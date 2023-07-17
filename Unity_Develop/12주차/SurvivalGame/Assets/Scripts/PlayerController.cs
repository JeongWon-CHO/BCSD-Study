using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //���ǵ� ���� ����
    [SerializeField]
    private float walkSpeed;

    [SerializeField]
    private float runSpeed;

    [SerializeField]
    private float crouchSpeed;

    private float applySpeed;

    [SerializeField]
    private float jumpForce;

    // ���� ����
    private bool isRun = false;
    private bool isCrouch = false;
    private bool isGround = true;

    // �ɾ��� �� �󸶳� ������ �����ϴ� ����
    [SerializeField] 
    private float crouchPosY;
    private float originPosY;
    private float applyCrouchPosY;



    // �� ���� ����
    private CapsuleCollider capsuleCollier;

    // �ΰ���
    [SerializeField]
    private float lookSensitivity;

    // ī�޶� �Ѱ�
    [SerializeField]
    private float cameraRotationLimit;
    private float currentCameraRotationX = 0; // �⺻���� 0�̶� �����ص� ������

    // �ʿ��� ������Ʈ
    [SerializeField]
    private Camera theCamera;
    private Rigidbody myRigid;

    // Start is called before the first frame update
    void Start()
    {
        capsuleCollier = GetComponent<CapsuleCollider>();
        myRigid = GetComponent<Rigidbody>();
        applySpeed = walkSpeed;
        originPosY = theCamera.transform.localPosition.y;
        applyCrouchPosY = originPosY;

    }

    // Update is called once per frame
    void Update()
    {
        IsGround();
        TryJump();
        TryRun();
        TryCrouch();
        Move();
        CameraRotation();
        CharacterRotation();
    }


    private void TryCrouch()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Crouch();
        }
    }


    private void Crouch()
    {
        isCrouch = !isCrouch;

        if (isCrouch)
        {
            applySpeed = crouchSpeed;
            applyCrouchPosY = originPosY;
        }
        else
        {
            applySpeed = walkSpeed;
        }

        StartCoroutine(CrouchCoroutine());
        theCamera.transform.localPosition = new Vector3(theCamera.transform.localPosition.x, applyCrouchPosY, theCamera.transform.localPosition.z);
    
    }

    IEnumerator CrouchCoroutine()
    {
        float _posY = theCamera.transform.localPosition.y;
        
        while(_posY != applyCrouchPosY)
        {
            _posY = Mathf.Lerp(_posY, applyCrouchPosY, 0.3f);
            theCamera.transform.localPosition = new Vector3(0, _posY, 0);
            yield return null;
        }

        //yield return new WaitForSeconds(1f);
    }



    private void IsGround()
    {
        isGround = Physics.Raycast(transform.position, Vector3.down, capsuleCollier.bounds.extents.y + 0.1f);
    }


    private void TryJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            Jump();
        }
    }

    private void Jump()
    {
        myRigid.velocity = transform.up * jumpForce;
    }



    private void TryRun()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Running();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            RunningCancle();
        }
    }

    private void Running()
    {
        isRun = true;
        applySpeed = runSpeed;
    }

    private void RunningCancle()
    {
        isRun = false;
        applySpeed = walkSpeed;
    }



    private void Move()
    {
        float _moveDirX = Input.GetAxisRaw("Horizontal"); // ������ 1, ����-1 �� ������ 0 ����
        float _moveDirZ = Input.GetAxisRaw("Vertical");

        Vector3 _moveHorizontal = transform.right * _moveDirX;
        Vector3 _moveVertical = transform.forward * _moveDirZ;

        Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * applySpeed; // �� ����ȭ ��Ű��

        myRigid.MovePosition(transform.position + _velocity * Time.deltaTime);

    }


    private void CameraRotation()
    {
        // ���� ī�޶� ȸ��

        float _xRotation = Input.GetAxisRaw("Mouse Y");
        float _cameraRotationX = _xRotation * lookSensitivity;
        currentCameraRotationX -= _cameraRotationX; // +�� �ϸ� ���콺 ���� ���
        currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);

        theCamera.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);
    }


    private void CharacterRotation()
    {
        // �¿� ĳ���� ȸ��
        float _yRotation = Input.GetAxisRaw("Mouse X");
        Vector3 _characterRotationY = new Vector3(0f, _yRotation, 0f) * lookSensitivity;
        myRigid.MoveRotation(myRigid.rotation * Quaternion.Euler(_characterRotationY));

    }
}