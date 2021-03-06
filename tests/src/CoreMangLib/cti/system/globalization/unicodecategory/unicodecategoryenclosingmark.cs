using System;
using System.Globalization;
/// <summary>
/// UnicodeCategory.EnclosingMark [v-minch]
/// </summary>
public class UnicodeCategoryEnclosingMark
{
    public static int Main()
    {
        UnicodeCategoryEnclosingMark unicodeEnclosingMark = new UnicodeCategoryEnclosingMark();
        TestLibrary.TestFramework.BeginTestCase("UnicodeCategoryEnclosingMark");
        if (unicodeEnclosingMark.RunTests())
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
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        return retVal;
    }
    #region PositiveTest
    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1:Return the EnclosingMark Value in UnicodeCategory Enumerator");
        try
        {
            UnicodeCategory myUnicodeCategory = UnicodeCategory.EnclosingMark;
            if (myUnicodeCategory != (UnicodeCategory)7)
            {
                TestLibrary.TestFramework.LogError("001", "the ExpectResult is 7 but the ActualResult is " + myUnicodeCategory.GetHashCode());
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpect exception:" + e);
            retVal = false;
        }
        return retVal;
    }
    #endregion
}