using System;
using System.Collections.Generic;

internal class Garage
{
    private Dictionary<string, Vehicle> m_VehiclesInGarage;

    //METHODS
    public bool PutNewVehicleInGarageRequest(string i_LicenseNumber)
    {
        bool vehicleAlreadyInGarage = isVehicleAlreadyInGarage(i_LicenseNumber);

        if (vehicleAlreadyInGarage)
        {
            //should call ConsoleIO.VehicleIsAlreadyInGarageMessage() from ConsoleUI

            //change VehicleStatus of vehicle to- underRepair
            m_VehiclesInGarage[i_LicenseNumber].RepairStatus = Enum.ERepairStatus.UnderRepair;
        }
        else
        {
            putVehicleInGarage(i_LicenseNumber);
        }

        return vehicleAlreadyInGarage;
    }

    private bool isVehicleAlreadyInGarage(string i_LicenseNumber)
    {
        //check if there is a key - string m_LicenseNumber in m_VehicledInGarage
        bool isVehicleAlreadyInGarage = m_VehiclesInGarage.ContainsKey(i_LicenseNumber);

        return isVehicleAlreadyInGarage; 
    }

    //CONSOLE should get params
    private void putVehicleInGarage(string i_LicenseNumber)
    {
        //This function should ask Owner for vehicle details:
        //type of vehicle, vehicle's parts status (air pressure and others) ...
        //WHEELS: can ask for 1 wheel status and set all same 
        //ERROR MESSAGES: can implent after all details are collected, instead of checking each one
    }

    public void DisplayVehiclesInGarage()
    {
        //ask which status
        //method for options, ask to choose a number, 0 for no sort
    }

    private void displayVehiclesInGarageWithousSorting()
    {
        //should create a list of strings (license number + repair status) and status
        //return to console and display 
    }

    private void displayVehiclesInGarageBySort(Enum.ERepairStatus i_RepairStatus)
    {
        //should get from console which status to sort
        //should create a list of strings (license number + repair status) and status
        //return to console and display 
    }

    public void ChangeVehicleRepairStatus(string i_LicenseNumber, int i_RepairStatus)
    {
        //get details from user: LicenseNumber, new repair status
        if(i_LicenseNumber != null)
        {
            m_VehiclesInGarage[i_LicenseNumber].RepairStatus = (Enum.ERepairStatus)(i_RepairStatus);
        }
    }

    public void InflateVehicleWheels()
    {
        //get license number
    }

    public void FillVehicleWithFuel()
    {
        //get license number
        //get type of fuel
        //get amount of fuel
    }

    public void ChargeVehicleWithElectricity()
    {
        //get license number
        //get amount of time
    }

    public void DisplayVehicleFullDetails()
    {
        //license number
        //model
        //owner
        //repair status
        //detail for this specifi kind of vehicle
    }
}

