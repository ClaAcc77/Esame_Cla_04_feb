using UnityEngine;

public class Cursor : MonoBehaviour
{
    Transform cursorContainerTransform;
    CursorContainer cursorContainer;
    PlayerManager playerMnaager;

    public float TimerToAttack = 4f;
    public float Timer = 0f;

    public void Awake()
    {
        cursorContainer = FindAnyObjectByType<CursorContainer>();
        playerMnaager = FindAnyObjectByType<PlayerManager>();

        cursorContainer.transform.position = new Vector3(0, 0, 0);
    }

    public void Update()
    {
        if(cursorContainer != null)
        {
            cursorContainerTransform = GetComponent<Transform>();

            if(cursorContainerTransform != null)
            {
                cursorContainer.transform.Rotate(0, 0, Time.deltaTime * 10);

                if(Timer < TimerToAttack)
                {
                    Timer += Time.deltaTime;

                    if(Timer >= TimerToAttack)
                    {
                        if(playerMnaager != null)
                        {
                            playerMnaager.GainCookies(1);
                            
                        }

                        Timer = 0;

                    }
                }
            }
            
        }
        
    }



}
