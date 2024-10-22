public class AccountCompareName: IComparer<Account>
{
    public int Compare(Account x, Account y)
    {
        return x.Name.CompareTo(y.Name);
    }
}