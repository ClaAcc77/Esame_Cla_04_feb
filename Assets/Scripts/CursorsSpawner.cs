using System.Collections.Generic;
using UnityEngine;

public class CursorsSpawner : MonoBehaviour
{
    List<Cursor> cursorsSpawned = new List<Cursor>();
    public List<GameObject> slots = new List<GameObject>();
    public Cursor cursorPrefab;

    public UiManager uiManager;
    public PlayerManager playerMnaager;

    int currentSlot = 0;
    public int cursorsToSpawn = 1;  
    bool Spawns;

    



    public void Event_Spawn()
    {

        if (cursorsSpawned.Count < 20)
        {
            Cursor prefab = Instantiate(cursorPrefab, slots[currentSlot].transform);
            cursorsSpawned.Add(prefab);
            currentSlot++;
            Spawns = false;

            playerMnaager.ResetCookies();
        }
        
        
    }

    public void Update()
    {
        


    }

   
}
