﻿namespace Tuber.Core.Exceptions;
public class TemperatureBelowAbsoluteZeroException : Exception
{
    public TemperatureBelowAbsoluteZeroException(double badValue)
        : base($"Temperature \"{badValue}\" cannot be below Absolute Zero")
    {

    }
}
