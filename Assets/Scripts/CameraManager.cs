using UnityEngine;


public class CameraManager : MonoBehaviour
{


    public Transform Player;

    public float SmoothingFactor = 8;



    Transform Camera;

    // 0 = Not moving, 1 = Right, 2 = Left, 3 = Up, 4 = Down.
    short cameraMovement = 0;

    Vector3 offset;

    void Start()
    {
        Camera = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Player.position.x >= Camera.position.x && Camera.position.x < 2770f)
        {
            Camera.position = Vector3.Lerp(Camera.position, new Vector3(Player.position.x, Player.position.y + 1f, -50), Time.deltaTime * SmoothingFactor);

            cameraMovement = 1;
        }

        else if (Player.position.x <= (Camera.position.x - 7f) && Camera.position.x > 423.5f)
        {
            Camera.position = Vector3.Lerp(Camera.position, new Vector3(Player.position.x + 7f, Player.position.y + 1f, -50), Time.deltaTime * SmoothingFactor);

            cameraMovement = 2;
        }

        else
        {
            Camera.position = Vector3.Lerp(Camera.position, new Vector3(Camera.position.x, Player.position.y + 1f, -50), Time.deltaTime * SmoothingFactor);

            cameraMovement = 0;
        }

        if (Player.position.y >= Camera.position.y && Camera.position.y < -1166f)
        {

        }

        if (Camera.position.x < 423.5f)
        {
            Camera.position = new Vector3(423.5f, Camera.position.y, -50);
        }

    }
}