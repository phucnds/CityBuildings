using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DPs;

public class ResourceManagerTestStud : MonoBehaviour, IResourceManager
{
    public float MoneyCalculationInterval { get; }

    public int StartMoneyAmount { get; }

    public int DemolitionPrice { get; }

    public void AddMoney(int amount)
    {
    }

    public void CalculateTownIncome()
    {

    }

    public bool CanIBuyIt(int amount)
    {
        return true;
    }

    public int HowManyStructuresCanIPlace(int placementCost, int count)
    {
        return 0;
    }

    public void PrepareResourceManager(BuildingManager buildingManager)
    {
    }

    public bool SpendMoney(int amount)
    {
        return true;
    }

    public void AddToPopulation(int value)
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void ReducePopulation(int value)
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}