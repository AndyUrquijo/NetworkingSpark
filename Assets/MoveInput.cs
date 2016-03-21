using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MoveInput : NetworkBehaviour 
{
    public Vector2 input;
    void Update()
    {
        if (!isLocalPlayer)
            return;
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        Vector3 moveDelta = new Vector3(input.x, 0, input.y) * Time.deltaTime;
        transform.position += moveDelta;
    }
}
