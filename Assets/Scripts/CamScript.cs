using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public GameControl gameC;
    float sens = 5f;
    float soft = 2f;

    Vector2 transitionPos;
    Vector2 camPos;

    GameObject player;
    void Start()
    {
        player = transform.parent.gameObject;
        camPos.y = 12;
    }

    void Update()
    {
        if (gameC.gameActive)
        {
            Vector2 mousePos = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            mousePos = Vector2.Scale(mousePos, new Vector2(sens * soft, sens * soft));
            transitionPos.x = Mathf.Lerp(transitionPos.x, mousePos.x, 1f / soft);
            transitionPos.y = Mathf.Lerp(transitionPos.y, mousePos.y, 1f / soft);

            camPos += transitionPos;

            transform.localRotation = Quaternion.AngleAxis(-camPos.y, Vector3.right);
            player.transform.localRotation = Quaternion.AngleAxis(camPos.x, player.transform.up);

        }

    }
}
