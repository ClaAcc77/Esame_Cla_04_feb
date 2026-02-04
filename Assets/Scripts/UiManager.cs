using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI cookieAmountText;
    public TextMeshProUGUI cursorNeededNumber;

    public void UpdateCookieAmount(int cookieNumber)
    {
        cookieAmountText.text = cookieNumber.ToString();
    }

    public void UpdateCursorNeededNumber(int cursorNumber)
    {
        cursorNeededNumber.text = cursorNumber.ToString();
    }

   

   

}
