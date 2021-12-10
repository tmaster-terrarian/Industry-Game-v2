using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class BuildingCreator : Singleton<BuildingCreator>
{
    [SerializeField] Tilemap previewMap;
    [SerializeField] Tilemap buildingMap;
    Controls playerInput;

    public Text debugText;

    TileBase tileBase;
    BuildingObjectBase selectedObject;

    Camera _camera;

    Vector2 mousePos;
    Vector3Int currentGridPos;
    Vector3Int lastGridPos;


    protected override void Awake()
    {
        base.Awake();
        playerInput = new Controls();
        _camera = Camera.main;
    }

    private void OnEnable()
    {
        playerInput.Enable();

        playerInput.Gameplay.MousePos.performed += OnMouseMove;
        playerInput.Gameplay.LeftClick.performed += OnLeftClick;
        playerInput.Gameplay.RightClick.performed += OnRightClick;
        playerInput.Gameplay.DeleteShortcut.performed += OnDeleteObject;
    }

    private void OnDisable()
    {
        playerInput.Disable();

        playerInput.Gameplay.MousePos.performed -= OnMouseMove;
        playerInput.Gameplay.LeftClick.performed -= OnLeftClick;
        playerInput.Gameplay.RightClick.performed -= OnRightClick;
        playerInput.Gameplay.DeleteShortcut.performed -= OnDeleteObject;
    }

    private BuildingObjectBase SelectedObject
    {
        set
        {
            selectedObject = value;

            tileBase = selectedObject != null ? selectedObject.TileBase : null;

            UpdatePreview();
        }
    }

    private void Update()
    {
        //if something is selected, show preview
        if (selectedObject != null)
        {
            Vector3 pos = _camera.ScreenToWorldPoint(mousePos);
            Vector3Int gridPos = previewMap.WorldToCell(pos);

            if(gridPos != currentGridPos)
            {
                lastGridPos = currentGridPos;
                currentGridPos = gridPos;

                UpdatePreview();
            }
        }
        if(selectedObject != null)
        {
            debugText.text = ""
            + selectedObject.TileBase.ToString() + "\n"
            + mousePos.ToString() + "\n"
            + currentGridPos + "\n"
            + "";
        }
        else
        {
            debugText.text = ""
            + mousePos.ToString() + "\n"
            + "";
        }
    }

    private void OnMouseMove(InputAction.CallbackContext ctx)
    {
        mousePos = ctx.ReadValue<Vector2>();
    }

    private void OnLeftClick(InputAction.CallbackContext ctx)
    {
        if(selectedObject != null && !EventSystem.current.IsPointerOverGameObject())
        {
            HandleDrawing();
        }
    }

    private void OnRightClick(InputAction.CallbackContext ctx)
    {
        SelectedObject = null;
    }

    private void OnDeleteObject(InputAction.CallbackContext ctx)
    {
        HandleDestroying();
    }

    public void ObjectSelected(BuildingObjectBase obj)
    {
        selectedObject = obj;
    }

    private void UpdatePreview()
    {
        previewMap.SetTile(lastGridPos, null);
        previewMap.SetTile(currentGridPos, tileBase);
    }

    private void HandleDrawing()
    {
        DrawItem();
    }

    private void DrawItem()
    {
        buildingMap.SetTile(currentGridPos, selectedObject.TileBase);
    }

    private void HandleDestroying()
    {
        buildingMap.SetTile(currentGridPos, null);

        if(selectedObject == null)
        {
            buildingMap.SetTile(currentGridPos, null);
        }
    }
}
