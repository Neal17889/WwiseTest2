using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageBoxTest : MonoBehaviour
{
    public void show()
    {
        MessageBox.Show("请选择你的飞行伴侣", "此生仅有一次的选择", MessageBoxType.Confirm, "佐巴扬", "牢大");
    }
}
