using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPers : MonoBehaviour
{
    // Контроль
    public float speed = 1.0f;
    Rigidbody rigitbody;
    float vert;
    float hor;
    private Animator anim;
    public GameObject pers;

    // Поворот
    public enum RotationAxes 
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;
    public float minimumVert = -90.0f;
    public float maximumVert = 90.0f;
    private float _rotationX = 0;

    void Start()
    {
        // Контроль
        rigitbody = GetComponent<Rigidbody>();
        anim = this.GetComponent<Animator>();

        // Поворот
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
            body.freezeRotation = true;
    }

    void Update()
    {
        // Поворот Персонажа:

        if (axes == RotationAxes.MouseX) 
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY) 
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else 
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }

        // Контроль персонажа:

        RaycastHit hit;

        if ((hor == 0) && (vert == 0))
        {
            anim.SetBool("Wait", true);
            anim.SetBool("Right", false);
            anim.SetBool("Left", false);
            anim.SetBool("Forward", false);
            anim.SetBool("Back", false);
        }

        if (hor > 0)
        {
            anim.SetBool("Right", true);
            anim.SetBool("Left", false);
            anim.SetBool("Forward", false);
            anim.SetBool("Back", false);
            anim.SetBool("Wait", false);
        }

        else if (hor < 0)
        {
            anim.SetBool("Left", true);
            anim.SetBool("Right", false);
            anim.SetBool("Forward", false);
            anim.SetBool("Back", false);
            anim.SetBool("Wait", false);
        }

        else if (vert > 0)
        {
            anim.SetBool("Forward", true);
            anim.SetBool("Left", false);
            anim.SetBool("Righth", false);
            anim.SetBool("Back", false);
            anim.SetBool("Wait", false);
        }

        else if (vert < 0)
        {
            anim.SetBool("Back", true);
            anim.SetBool("Forward", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
            anim.SetBool("Wait", false);
        }
    
        if (Input.GetKeyDown(KeyCode.LeftShift))
            speed = speed * 2;
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            speed = speed / 2;

        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        rigitbody.AddForce(((transform.right*hor) + transform.forward*vert) * speed / Time.deltaTime);

        //Прыжок
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // transform.position = Vector3.up * 30;
            pers.transform.position = new Vector3(pers.transform.position.x, pers.transform.position.y + 5, pers.transform.position.z);
        }
    }
}
