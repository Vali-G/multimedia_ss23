using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{


    [Header("Keybinds")]
    [SerializeField] private string inputMouseX;
    [SerializeField] private string inputMouseY;

    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //get Mouse input
        float mouseX = Input.GetAxisRaw(inputMouseX) * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw(inputMouseY) * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //rotate cam and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);



    }
}
