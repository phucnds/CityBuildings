using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DPs
{
    [CreateAssetMenu(fileName = "New collection", menuName = "CityBuilder/CollectionSO")]
    public class CollectionSO : ScriptableObject
    {
        public RoadStructureSO roadStructure;
        public List<SingleStructureBaseSO> singleStructureList;
        public List<ZoneStructureSO> zonesList;
    }
}