using UnityEngine;

public class Cookie : MonoBehaviour
{
    public PlayerManager playerManager;

    public void OnClick()
    {
        transform.localScale = new Vector3(transform.localScale.x * 1.2f, transform.localScale.y * 1.2f, 1);
        playerManager.GainCookies(1);
    }

    public void ResetScale()
    {
        transform.localScale = new Vector3(transform.localScale.x / 1.2f, transform.localScale.y / 1.2f, 1);
    }

}
