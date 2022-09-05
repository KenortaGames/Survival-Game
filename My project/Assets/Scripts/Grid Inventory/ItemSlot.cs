using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Item item;
    public Image icon;
    public bool hovered;
    public int slotPlaceID;
    public int partID;
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(item){
            for (int i = 0; i < item.icon.Count; i++)
            {
                if(i == partID - 1){
                icon.sprite = item.icon[i];
                }
            }
            icon.gameObject.SetActive(true);
        }else{
            icon.gameObject.SetActive(false);
        }
        /*if(item && hovered){
            if(Input.GetKeyDown(KeyCode.U)){
                switch(item.itemSize){
                    case ItemInventorySizes._1x1:
                        item = null;
                    break;                        
                    case ItemInventorySizes._1x2:
                        int itemsCounted = 0;
                        for (int i = 0; i < Inventory.instance.itemSlots.Count; i++)
                        {
                            if(itemsCounted < Inventory.instance.itemSlots.Count){
                                if(Inventory.instance.itemSlots[i].partID == partID){
                                    item = null;
                                    itemsCounted++;
                                    Debug.Log(itemsCounted);
                                }
                            }else{
                                itemsCounted = 0;
                            }
                        }
                    break;
                    case ItemInventorySizes._1x3:
                        int itemsCounted1x3 = 0;
                        for (int i = 0; i < Inventory.instance.itemSlots.Count; i++)
                        {
                            if(itemsCounted1x3 < Inventory.instance.itemSlots.Count){
                                if(Inventory.instance.itemSlots[i].partID == partID){
                                    item = null;
                                    itemsCounted1x3++;
                                }
                            }else{
                                itemsCounted1x3 = 0;
                            }
                        }
                    break;                        
                    case ItemInventorySizes._2x2:    
                        int itemsCounted2x2 = 0;
                        for (int i = 0; i < Inventory.instance.itemSlots.Count; i++)
                        {
                            if(itemsCounted2x2 < Inventory.instance.itemSlots.Count){
                                if(Inventory.instance.itemSlots[i].partID == partID){
                                    item = null;
                                    itemsCounted2x2++;
                                }
                            }else{
                                itemsCounted2x2 = 0;
                            }
                        }
                    break;                        
                    case ItemInventorySizes._2x3:   
                        int itemsCounted2x3 = 0;
                        for (int i = 0; i < Inventory.instance.itemSlots.Count; i++)
                        {
                            if(itemsCounted2x3 < Inventory.instance.itemSlots.Count){
                                if(Inventory.instance.itemSlots[i].partID == partID){
                                    item = null;
                                    itemsCounted2x3++;
                                }
                            }else{
                                itemsCounted2x3 = 0;
                            }
                        }
                    break;                  
                }
            }
        }*/
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        hovered = true;
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        hovered = false;
    }
}
