using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest : MonoBehaviour
{

    private Dictionary<string, int> items = new Dictionary<string, int>();
    // Start is called before the first frame update


    void Start()
    {
        AddItem("포션", 6);
        AddItem("엘릭서", 2);

        UseItem("포션");

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
        Debug.Log("추가 " + quantity + " " + ItemName + "(을) 인벤토리로");
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
            Debug.Log("사용한 아이템 : " + ItemName);
        }
    }
    void PrintInventory()
    {
       foreach (KeyValuePair<string, int> item in items)
        {
            Debug.Log("아이템 : " + item.Key + ", 수량 : "+item.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
