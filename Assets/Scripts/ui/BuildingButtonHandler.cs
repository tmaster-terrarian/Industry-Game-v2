using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using IndV2.Buildings;

public class BuildingButtonHandler : MonoBehaviour
{
    [SerializeField] BuildingObjectBase item;
    Button button;

    BuildingCreator buildingCreator;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonClicked);
        buildingCreator = BuildingCreator.GetInstance();
    }

    private void ButtonClicked()
    {
        Debug.Log("Player has selected: " + item.name + " (object building category)");
        buildingCreator.ObjectSelected(item);
    }
}
