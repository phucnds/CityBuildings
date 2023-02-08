using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DPs;

public class PlacementTest : MonoBehaviour
{
    public GameObject placementObject;
    public LayerMask mouseInputMask;

    private GameObject place;
    public int width = 2;
    public int height = 2;
    

    private GridStructure grid;

    private void PlacingPrefab()
    {
        if(gameObject != null)
        {
            Destroy(place);
        }
        place = Instantiate(placementObject);
    }

    private Vector3? GetMousePosition()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Vector3? position = null;
        if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity, mouseInputMask))
        {
            position = hit.point - new Vector3(1,0,1);

        }

        return position;
    }

    // Start is called before the first frame update
    void Start()
    {
        grid = new GridStructure(5, 200, 200);
        PlacingPrefab();
    }

    // Update is called once per frame
    void Update()
    {
        if (place != null)
        {
            Vector3? position = GetMousePosition();
            if (position.HasValue)
            {
                place.transform.position = grid.CalculateGridPosition(position.Value);
                if (Input.GetMouseButtonDown(0))
                {
                    Destroy(place);
                    Instantiate(placementObject, grid.CalculateGridPosition(position.Value), Quaternion.identity);
                    Debug.Log(grid.CalculateGridPosition(position.Value));
                }
            }

             
        }
    }

    public int GetRotationAngle(Direction dir)
    {
        switch (dir)
        {
            default:
            case Direction.Down: return 0;
            case Direction.Left: return 90;
            case Direction.Up: return 180;
            case Direction.Right: return 270;
        }
    }

    public Vector2Int GetRotationOffset(Direction dir)
    {
        switch (dir)
        {
            default:
            case Direction.Down: return new Vector2Int(0, 0);
            case Direction.Left: return new Vector2Int(0, width);
            case Direction.Up: return new Vector2Int(width, height);
            case Direction.Right: return new Vector2Int(height, 0);
        }
    }

    public List<Vector2Int> GetGridPositionList(Vector2Int offset, Direction dir)
    {
        List<Vector2Int> gridPositionList = new List<Vector2Int>();
        switch (dir)
        {
            default:
            case Direction.Down:
            case Direction.Up:
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        gridPositionList.Add(offset + new Vector2Int(x, y));
                    }
                }
                break;
            case Direction.Left:
            case Direction.Right:
                for (int x = 0; x < height; x++)
                {
                    for (int y = 0; y < width; y++)
                    {
                        gridPositionList.Add(offset + new Vector2Int(x, y));
                    }
                }
                break;
        }
        return gridPositionList;
    }
}
