using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest : MonoBehaviour
{

    private Dictionary<string, int> items = new Dictionary<string, int>();
    // Start is called before the first frame update


    void Start()
    {
        AddItem("����", 6);
        AddItem("������", 2);

        UseItem("����");

        PrintInventory();
    }
    void AddItem(string ItemName, int quantity)
    {
        if(items.ContainsKey(ItemName))
        {
            items[ItemName] += quantity;
        }
        else
        {
            items.Add(ItemName, quantity);
        }
        Debug.Log("�߰� " + quantity + " " + ItemName + "(��) �κ��丮��");
    }
    void UseItem(string ItemName)
    {
        if (items.ContainsKey(ItemName))
        {
            items[ItemName]--;

            if (items[ItemName]<=0)
            {
                items.Remove(ItemName);
            }
            Debug.Log("����� ������ : " + ItemName);
        }
    }
    void PrintInventory()
    {
       foreach (KeyValuePair<string, int> item in items)
        {
            Debug.Log("������ : " + item.Key + ", ���� : "+item.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
