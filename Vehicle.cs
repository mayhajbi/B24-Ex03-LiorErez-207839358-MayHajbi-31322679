using System;
using System.Collections.Generic;
using static Garage;

internal class Vehicle    //abstract?
{
    //Vehicle Propertis
    private string m_ModelName;
    private string m_LicenseNumber;
    private float m_EnergyPercentage;
    private List<Wheel> m_Wheels;       //maybe Wheel should be a nested class/ struct

    //VehicleInGarageDetails
    private string m_NameOfOwner;
    private string m_PhoneNumberOfOwner;
    private Enum.ERepairStatus m_VehicleRepairStatus = Enum.ERepairStatus.UnderRepair;

    private string LicenseNumber
    {
        get { return m_LicenseNumber; }
        set { m_LicenseNumber = value; }
    }

    public Enum.ERepairStatus RepairStatus
    {
        get { return m_VehicleRepairStatus; }
        set { m_VehicleRepairStatus = value; }
    }


    //METHODS

}

