﻿using UnityEngine;

public enum ItemType { Bow, Bomb, Boomerang, PowerBracelet, Key, Sword, WhiteSword, MagicalSword, BlueRing, RedRing }

[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]
public class ItemDescriptor : ScriptableObject
{
    public string itemName = "New item";
    public ItemType itemType = default;
    public bool isConsumamble = default;
    public bool isPassive = default;
    public int consumambleUses = default;
    public Sprite icon = default;
}
