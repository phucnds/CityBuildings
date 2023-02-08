using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DPs
{
    [CreateAssetMenu(fileName = "New zone structure", menuName = "CityBuilder/StructureData/ZoneStructure")]
    public class ZoneStructureSO : StructureBaseSO
    {
        public bool upgradable;
        public GameObject[] prefabVariants;
        public UpgradeType[] availableUpgrades;
        public ZoneType zoneType;
        public int maxFacilitySearchRange;
    }

    [System.Serializable]
    public struct UpgradeType
    {
        public GameObject[] prefabVariants;
        public int happinessThreshold;
        public int newIncome;
        public int newUpkeep;
    }

    public enum ZoneType
    {
        Residential,
        Agricultural,
        Commercial
    }
}