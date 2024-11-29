using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTest : MonoBehaviour
{
    public void show()
    {
        Debug.Log(DataManager.Instance.Shops[1].Description);
    }
}
