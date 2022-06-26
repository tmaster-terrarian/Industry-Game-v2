using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public enum BuildingCategory
{
    None,
    Belt,
    Machine
}

[CreateAssetMenu (fileName = "Buildable", menuName = "BuildingObjects/Buildable")]
public class BuildingObjectBase : ScriptableObject
{
    [SerializeField] protected BuildingCategory category;
    [SerializeField] protected TileBase tileBase;

    public TileBase TileBase
    {
        get
        {
            return tileBase;
        }
    }

    public BuildingCategory Category
    {
        get
        {
            return category;
        }
    }
}
