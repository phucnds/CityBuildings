using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DPs
{
    public class Cell
    {
        GameObject structureModel = null;
        List<GameObject> natureList = new List<GameObject>();
        StructureBaseSO structureData;
        bool isTaken = false;

        public bool IsTaken { get => isTaken; }

        public void SetConstruction(GameObject structureModel, StructureBaseSO structureData)
        {
            if (structureModel == null)
                return;
            this.structureModel = structureModel;
            this.isTaken = true;
            this.structureData = structureData;
        }


        public GameObject GetStructure()
        {
            return structureModel;
        }

        public void RemoveStructure()
        {
            structureModel = null;
            isTaken = false;
            structureData = null;
        }

        public StructureBaseSO GetStructureData()
        {
            return structureData;
        }

        public void AddNatureObject(GameObject element)
        {
            natureList.Add(element);
        }

        public List<GameObject> GetNatureOnThisCell()
        {
            return natureList;
        }
    }

}