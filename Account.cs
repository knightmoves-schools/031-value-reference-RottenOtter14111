namespace knightmoves;

public class Account {
    public static int OriginalTaxRate = 10;
    public static int[] CurrentLedger = {10, 20, 30, 40, 50};

    // Add your code here
    public static int NewTaxRate = OriginalTaxRate;
    public static int[] CopyLedger = CurrentLedger;

    public int[] UpdateLedger(int correction)
    {
        CurrentLedger[0] = correction;
        return CurrentLedger;
    }
    public int AdjustTaxRate(int taxRate)
    {
        NewTaxRate = taxRate;
        return NewTaxRate;
    }
}

