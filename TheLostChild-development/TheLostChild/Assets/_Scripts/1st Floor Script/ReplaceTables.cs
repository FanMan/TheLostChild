using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceTables : MonoBehaviour
{
    public GameObject OriginalTable;
    public GameObject FixedTable;
    public GameObject TableTrigger;
    GameObject PlayerTemp;

    void Start()
    {
        
    }

    // temporary script before being replaced
    void OnTriggerExit(Collider c)
    {
        if(c.CompareTag("Player"))
        {
            SwitchTables();
        }
    }

    // execute this when player is looking away from the table at 180 degrees
    void SwitchTables()
    {
        // move the original table below the house
        OriginalTable.transform.position = new Vector3(0, -4.0f, 0);
        // set the object to false
        OriginalTable.SetActive(false);

        // play a quick sound to let the player know the table moved around

        // move the fixed table to the spot of the original table
        FixedTable.transform.position = new Vector3(-7.385f, 0, 0);
        // set it to active
        FixedTable.SetActive(true);

        //TableTrigger.SetActive(false);
    }
}
