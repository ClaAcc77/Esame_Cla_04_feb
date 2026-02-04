using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public UiManager uiManager;
    public ButtonManager buttonManager;
    public int cookies = 0;
    public int MinCookiesToActivate = 15;

    int currentNumberNeededCursor = 12;
    int NextNumberNeeded;
    int numberToAdd = 3;

    public void GainCookies(int cookie)
    {
        cookies++;
        uiManager.UpdateCookieAmount(cookies);
    }

   

    public void Update()
    {
        if(cookies >= NumberNeededForCursor())
        {
            buttonManager.SetInteractable(true);
            currentNumberNeededCursor += 3;
            
        }
    }

    public void ResetCookies()
    {
        cookies -= NumberNeededForCursor();

        if(cookies <= 0)
        {
            cookies = 0;
        }

        uiManager.UpdateCookieAmount(cookies);
        buttonManager.SetInteractable(false);
    }

    public int NumberNeededForCursor()
    {
        return currentNumberNeededCursor + numberToAdd;
    }

}
