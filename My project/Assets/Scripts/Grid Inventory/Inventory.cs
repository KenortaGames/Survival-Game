using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public List<ItemSlot> itemSlots;
    public List<int> slotIDs;
    public int verticalSlots;
    public int horizontalSlots;
    [Header("Testing")]
    public Item testItemAdd;
    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < itemSlots.Count; i++)
        {
            itemSlots[i].id = i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space)){
            AddItem(testItemAdd);
            Debug.Log("E Pressed");
        }
        for (int i = 0; i < itemSlots.Count; i++)
        {
            if(itemSlots[i].hovered && itemSlots[i].item){
                if(Input.GetKeyDown(KeyCode.R)){
                    Debug.Log("Trying to rotate " + itemSlots[i].item);
                }
            }
        }*/
    }
    public void AddItem(Item itemToAdd)
    {
        for (int i = 0; i < itemSlots.Count; i++)
        {
            if(!itemSlots[i].item){
                int id = Random.Range(0, 100000);
                slotIDs.Add(id);    
                switch (itemToAdd.itemSize)
                {
                    case ItemInventorySizes._1x1:
                        itemSlots[i].item = itemToAdd;

                        itemSlots[i].id = id;

                        itemSlots[i].partID = 1;
                    break;

                    case ItemInventorySizes._1x2:
                        if(itemSlots[i + horizontalSlots].item == null && itemSlots[i + horizontalSlots].slotPlaceID < (i + horizontalSlots)){
                            itemSlots[i].item = itemToAdd;
                            itemSlots[i + horizontalSlots].item = itemToAdd;

                            itemSlots[i].id = id;
                            itemSlots[i + horizontalSlots].id = id;

                            itemSlots[i].partID = 1;
                            itemSlots[i + horizontalSlots].partID = 2;
                        }
                    break;

                    case ItemInventorySizes._1x3:
                            itemSlots[i].item = itemToAdd;
                            itemSlots[i + horizontalSlots].item = itemToAdd;
                            itemSlots[i + (horizontalSlots * 2)].item = itemToAdd;

                            itemSlots[i].id = id;
                            itemSlots[i + horizontalSlots].id = id;
                            itemSlots[i + (horizontalSlots * 2)].id = id;

                            itemSlots[i].partID = 1;
                            itemSlots[i + horizontalSlots].partID = 2;
                            itemSlots[i + (horizontalSlots * 2)].partID = 3;
                    break;

                    case ItemInventorySizes._2x2:
                        itemSlots[i].item = itemToAdd;
                        itemSlots[i + 1].item = itemToAdd;
                        itemSlots[i + horizontalSlots].item = itemToAdd;
                        itemSlots[i + horizontalSlots + 1].item = itemToAdd;

                        itemSlots[i].id = id;
                        itemSlots[i + 1].id = id;
                        itemSlots[i + horizontalSlots].id = id;
                        itemSlots[i + horizontalSlots + 1].id = id;
                                
                        itemSlots[i].partID = 1;
                        itemSlots[i + 1].partID = 2;
                        itemSlots[i + horizontalSlots].partID = 3;
                        itemSlots[i + horizontalSlots + 1].partID = 4;
                        itemSlots[i + 1].item = itemToAdd;
                        itemSlots[i + 1 + 1].item = itemToAdd;
                        itemSlots[i + horizontalSlots + 1].item = itemToAdd;
                        itemSlots[i + horizontalSlots + 1 + 1].item = itemToAdd;

                        itemSlots[i + 1].id = id;
                        itemSlots[i + 1 + 1].id = id;
                        itemSlots[i + horizontalSlots + 1].id = id;
                        itemSlots[i + horizontalSlots + 1 + 1].id = id;
                                
                        itemSlots[i + 1].partID = 1;
                        itemSlots[i + 1 + 1].partID = 2;
                        itemSlots[i + horizontalSlots + 1].partID = 3;
                        itemSlots[i + horizontalSlots + 1 + 1].partID = 4;
                    break;
                        
                    case ItemInventorySizes._2x3:
                        itemSlots[i].item = itemToAdd;
                        itemSlots[i + 1].item = itemToAdd;
                        itemSlots[i + 2].item = itemToAdd;
                        itemSlots[i + horizontalSlots].item = itemToAdd;
                        itemSlots[i + horizontalSlots + 1].item = itemToAdd;
                        itemSlots[i + horizontalSlots + 2].item = itemToAdd;

                        itemSlots[i].id = id;
                        itemSlots[i + 1].id = id;
                        itemSlots[i + 2].id = id;
                        itemSlots[i + horizontalSlots].id = id;
                        itemSlots[i + horizontalSlots + 1].id = id;
                        itemSlots[i + horizontalSlots + 2].id = id;
                            
                        itemSlots[i].partID = 1;
                        itemSlots[i + 1].partID = 2;
                        itemSlots[i + 2].partID = 3;
                        itemSlots[i + horizontalSlots].partID = 4;
                        itemSlots[i + horizontalSlots + 1].partID = 5;
                        itemSlots[i + horizontalSlots + 2].partID = 6;
                    break;                
                }
                break;
            }else{
                continue;
            }   
            
        }
    }
}
