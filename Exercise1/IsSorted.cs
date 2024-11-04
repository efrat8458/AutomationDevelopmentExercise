static bool IsSorted(int[] numArr)
{
    if (numArr == null || numArr.Length == 0)
    {
        return true;
    }
    bool ascendingFlag = numArr[0] <= numArr[1];
    for (int i = 1; i<numArr.Length-1;i++)
    {
        bool isAscending = numArr[i] <= numArr[i + 1];
        bool isDescending = numArr[i] >= numArr[i + 1];
        if (!((ascendingFlag && isAscending) || (!ascendingFlag && isDescending)))
        {
            return false;
        }
    }
    return true;
}
