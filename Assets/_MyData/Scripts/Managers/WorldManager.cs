using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DPs
{
    public class WorldManager : MonoBehaviour
    {
        public GameObject tree;
        public Transform natureParent;
        int width, length;
        GridStructure grid;
        public int radius = 5;

        public GridStructure Grid { get => grid;}

        public void PrepareWorld(int cellSize, int width, int length)
        {
            this.grid = new GridStructure(cellSize, width, length);
            this.width = width;
            this.length = length;
            PrepareTree();
        }

        private void PrepareTree()
        {
            TreeGenerator generator = new TreeGenerator(width, length, radius);
            foreach (Vector2 samplePosition in generator.Samples())
            {
                PlaceObjectOnTheMap(samplePosition,tree);
            }
        }

        private void PlaceObjectOnTheMap(Vector2 samplePosition, GameObject objectToCreate)
        {
            var positionInt = Vector2Int.CeilToInt(samplePosition);
            var positionGrid = grid.CalculateGridPosition(new Vector3(positionInt.x, 0, positionInt.y));
            var natureElement = Instantiate(objectToCreate, positionGrid, Quaternion.identity,natureParent);
            grid.AddNatureToCell(positionGrid, natureElement);
        }

        public void DestroyNatureAtLocation(Vector3 position)
        {
            var elementToDestroy = grid.GetNatureObjectsToRemove(position);

            foreach (var element in elementToDestroy)
            {
                Destroy(element);
            }
        }
    }
}

