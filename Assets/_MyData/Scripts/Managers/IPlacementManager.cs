using System.Collections.Generic;
using UnityEngine;

namespace DPs
{
    public interface IPlacementManager
    {
        GameObject CreateGhostStructure(Vector3 gridPosition, GameObject buildingPrefab, RotationValue rotationValue = RotationValue.R0);
        void DestroySingleStructure(GameObject structure);
        void DestroyStructures(IEnumerable<GameObject> structureCollection);
        void PlaceStructuresOnTheMap(IEnumerable<GameObject> structureCollection);
        void ResetBuildingLook(GameObject structure);
        void SetBuildingForDemolition(GameObject structureToDemolish);
        void PreparePlacmentManager(WorldManager worldManager);
        GameObject PlaceStructureOnTheMap(Vector3 gridPosition, GameObject buildingPrefab, RotationValue rotationValue);
        GameObject MoveStructureOnTheMap(Vector3Int positionToPlaceStructure, GameObject gameObjectToReuse, GameObject prefab);
    }
}