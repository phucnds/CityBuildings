using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DPs
{
    public class PlayerBuildingSingleStructureState : PlayerState
    {
        BuildingManager buildingManager;
        string structureName;

        public PlayerBuildingSingleStructureState(GameManager gameManager, BuildingManager buildingManager) : base(gameManager)
        {
            this.buildingManager = buildingManager;
        }

        public override void OnInputPointerDown(Vector3 position)
        {
            buildingManager.PrepareStructureForPlacement(position, this.structureName, StructureType.SingleStructure);
        }

        public override void OnConfirmAction()
        {
            this.buildingManager.ConfirmModification();
            base.OnConfirmAction();
            
        }

        public override void OnBuildArea(string structureName)
        {
            this.buildingManager.CancelModification();
            base.OnBuildArea(structureName);
            
        }

        public override void OnBuildRoad(string structureName)
        {
            this.buildingManager.CancelModification();
            base.OnBuildRoad(structureName);
            
        }

        public override void OnCancle()
        {
            this.buildingManager.CancelModification();
            this.gameManager.TransitionToState(this.gameManager.selectionState, null);
        }

        public override void EnterState(string structureName)
        {
            base.EnterState(structureName);
            this.buildingManager.PrepareBuildingManager(this.GetType());
            this.structureName = structureName;
        }

        public override void OnDemolishAction()
        {
            this.buildingManager.CancelModification();
            base.OnDemolishAction();
        }
    }
}