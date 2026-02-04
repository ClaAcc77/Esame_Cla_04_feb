using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button buttonsCursor;

    public void SetInteractable(bool interactables)
    {
        buttonsCursor.interactable = interactables;
    }

    public void Awake()
    {
        SetInteractable(false);
    }

}
