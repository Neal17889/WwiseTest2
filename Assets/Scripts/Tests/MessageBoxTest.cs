using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageBoxTest : MonoBehaviour
{
    public void show()
    {
        MessageBox.Show("��ѡ����ķ��а���", "��������һ�ε�ѡ��", MessageBoxType.Confirm, "������", "�δ�");
    }
}
