using UnityEngine;
using UnityEngine.InputSystem;

public class RayCastManager : MonoBehaviour
{
    public LayerMask raycastLayer;
    public Cookie cookie;

    public void Update()
    {
        Vector2 MouseScreenPos = Mouse.current.position.value;
        Vector2 MouseWorldPos = Camera.main.ScreenToWorldPoint(MouseScreenPos);

        RaycastHit2D hit = Physics2D.Raycast(MouseWorldPos, Vector2.zero, 500, raycastLayer);

        if(hit.collider != null)
        {
            if(Mouse.current.leftButton.wasPressedThisFrame && cookie != null)
            {
                cookie.OnClick();
                Invoke("ResetOriginalSprite", 0.1f);
            }
        }

    }

    public void ResetOriginalSprite()
    {
        if(cookie != null)
        {
            cookie.ResetScale();
        }
    }


}
