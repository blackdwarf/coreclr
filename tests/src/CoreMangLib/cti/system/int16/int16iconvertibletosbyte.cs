using System;

/// <summary>
/// Int16.IConverible.ToSbyte(IFormatProvider)
/// </summary>
public class Int16IConvertibleToSByte
{
    #region Public Methods
    public bool RunTests()
    {
        bool retVal = true;

        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        retVal = PosTest4() && retVal;
        retVal = PosTest5() && retVal;

        TestLibrary.TestFramework.LogInformation("[Negative]");
        retVal = NegTest1() && retVal;

        return retVal;
    }

    #region Positive Test Cases
    public bool PosTest1()
    {
        bool retVal = true;

        // Add your scenario description here
        TestLibrary.TestFramework.BeginScenario("PosTest1: Convert a random int16 to sbyte ");

        try
        {
            Int16 i1 = 200;
            while (i1 > 127)
            {
                i1 = (Int16)TestLibrary.Generator.GetByte(-55);
            }
            IConvertible Icon1 = (IConvertible)(i1);
            if (Icon1.ToSByte(null) != i1)
            {
                TestLibrary.TestFramework.LogError("001", "The result is not the value as expected,tht int16 is:" + i1);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            TestLibrary.TestFramework.LogInformation(e.StackTrace);
            retVal = false;
        }

        return retVal;
    }

    public bool PosTest2()
    {
        bool retVal = true;

        // Add your scenario description here
        TestLibrary.TestFramework.BeginScenario("PosTest2: Convert zero to sbyte ");

        try
        {
            Int16 i1 = 0;
            IConvertible Icon1 = (IConvertible)(i1);
            if (Icon1.ToSByte(null) != i1)
            {
                TestLibrary.TestFramework.LogError("003", "The result is not the value as expected");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004", "Unexpected exception: " + e);
            TestLibrary.TestFramework.LogInformation(e.StackTrace);
            retVal = false;
        }

        return retVal;
    }

    public bool PosTest3()
    {
        bool retVal = true;

        // Add your scenario description here
        TestLibrary.TestFramework.BeginScenario("PosTest3: Convert a negative int16 to sbyte ");

        try
        {
            Int16 i1 = 200;
            while (i1 > 127)
            {
                i1 = (Int16)TestLibrary.Generator.GetByte(-55);
            }
            IConvertible Icon1 = (IConvertible)(-i1);
            if (Icon1.ToSByte(null) != (-i1))
            {
                TestLibrary.TestFramework.LogError("005", "The result is not the value as expected,the int16 is:" + i1);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("006", "Unexpected exception: " + e);
            TestLibrary.TestFramework.LogInformation(e.StackTrace);
            retVal = false;
        }

        return retVal;
    }

    public bool PosTest4()
    {
        bool retVal = true;

        // Add your scenario description here
        TestLibrary.TestFramework.BeginScenario("PosTest4: Check the boundary value of sbyte.MinValue");

        try
        {

            Int16 i1 = (Int16)sbyte.MinValue;
            IConvertible Icon1 = (IConvertible)(i1);
            if (Icon1.ToSByte(null) != (i1))
            {
                TestLibrary.TestFramework.LogError("007", "The result is not the value as expected");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("008", "Unexpected exception: " + e);
            TestLibrary.TestFramework.LogInformation(e.StackTrace);
            retVal = false;
        }

        return retVal;
    }

    public bool PosTest5()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest5: Check the boundary value of sbyte.MaxValue");

        try
        {

            Int16 i1 = (Int16)sbyte.MaxValue;
            IConvertible Icon1 = (IConvertible)(i1);
            if (Icon1.ToSByte(null) != (i1))
            {
                TestLibrary.TestFramework.LogError("009", "The result is not the value as expected");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("010", "Unexpected exception: " + e);
            TestLibrary.TestFramework.LogInformation(e.StackTrace);
            retVal = false;
        }

        return retVal;
    }
    #endregion

    #region Nagetive Test Cases
    public bool NegTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("NegTest1: Test the overflowException");

        try
        {
            Int16 i1 = 0;
            while (i1 <= 127)
            {
                i1 = TestLibrary.Generator.GetInt16(-55);
            }
            IConvertible Icon1 = (IConvertible)(i1);
            if (Icon1.ToSByte(null) != i1)
            {
            }
            TestLibrary.TestFramework.LogError("101", "An overflowException was not thrown as expected ");
            retVal = false;
        }
        catch (OverflowException)
        {
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("102", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    #endregion
    #endregion

    public static int Main()
    {
        Int16IConvertibleToSByte test = new Int16IConvertibleToSByte();

        TestLibrary.TestFramework.BeginTestCase("Int16IConvertibleToSByte");

        if (test.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
}
