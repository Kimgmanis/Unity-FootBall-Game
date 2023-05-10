using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PushBall : MonoBehaviour
{
    [SerializeField]
    private float pushPower = 4f;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic)
        {
            return;
        }
        if(hit.moveDirection.y < -0.3)
        {
            return;
        }
        Vector3 pushDir = new Vector3(hit.moveDirection.x, hit.moveDirection.y, hit.moveDirection.z);
        body.velocity = pushDir * pushPower;
        Vector3 collisionPoint = hit.point;
        body.AddForceAtPosition(pushDir * pushPower, collisionPoint, ForceMode.Impulse);
    }

}
