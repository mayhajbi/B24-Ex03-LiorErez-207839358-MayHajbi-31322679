﻿using System;

internal class Wheel
{
    private readonly string m_ManufacturerName;
    private readonly float r_MaxAirPressureByManufacturer;
    private float m_CurrentAirPressure;

    //CTOR
    public Wheel(string i_ManufacturerName, float i_MaxAirPressureByManufacturer, float i_CurrentAirPressure)
    {
        m_ManufacturerName = i_ManufacturerName;
        r_MaxAirPressureByManufacturer = i_MaxAirPressureByManufacturer;
        m_CurrentAirPressure = i_CurrentAirPressure;
    }

    //METHODS
    private void inflatingWheel(float i_AirAmountToInflate)
    {

    }
}

