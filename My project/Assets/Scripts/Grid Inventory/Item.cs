using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item")]
public class Item : ScriptableObject
{    
    public List<Sprite> icon; 
    [Header("Size Info")]   
    public ItemInventorySizes itemSize;
    public int sizeX;
    public int sizeY;

}
public enum ItemInventorySizes{
    _1x1,
    _1x2,
    _1x3,
    _2x2,
    _2x3
}