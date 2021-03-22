
using UnityEngine;

public class Mouvements : MonoBehaviour     
{
    //camera control variables 
    public Transform player;
    public float MouseSensitivity = 10;

    private float x = 0;
    private float y = 0;

    //movement control variables
    public float movementSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        //get the mouse in the middle of the screen 
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        cameraControl();
    }

    private void cameraControl()
    {
        x += Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        y += -Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        y = Mathf.Clamp(y, -40, 40);

        //transform.localRotation = Quaternion.Euler(0, x, 0);
        player.transform.localRotation = Quaternion.Euler(0, x, y);
     
        //this is to have a way to stop the game.
        if (Input.GetKeyDown(KeyCode.Escape)) Cursor.lockState = CursorLockMode.None;
    }

}
