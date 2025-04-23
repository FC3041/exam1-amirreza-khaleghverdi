namespace Exam1;

public class Q8StringLengthComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        if(x==null&&y!=null)
        return -1;
        else if(y==null&&x!=null)
        return 1;
        else if(x==null&&y==null)
        return 0;
        else
        {
            if(x.Count()>y.Count())
            return 1;
            else if(x.Count()<y.Count())
            return -1;
            else
            {
                return x.CompareTo(y);
            }
        }
    }
}

public class Q8ComparableString
{
    public object value;

    public Q8ComparableString(object value)
    {
        this.value =(Q8ComparableString)value;
    }

    public static bool operator ==(Q8ComparableString a,Q8ComparableString b)
    {
        return a==b;
    }

    public static bool operator !=(Q8ComparableString a,Q8ComparableString b)
    {
        return a!=b;
    }

    public static bool operator >(Q8ComparableString a,Q8ComparableString b)
    {
        return a>b;
    }

    public static bool operator <(Q8ComparableString a,Q8ComparableString b)
    {
        return a<b;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (ReferenceEquals(obj, null))
        {
            return false;
        }

        throw new NotImplementedException();
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }

    // public int Compare(string x, string y)
    // {
    //     if(x==null&&y!=null)
    //     return -1;
    //     else if(y==null&&x!=null)
    //     return 1;
    //     else if(x==null&&y==null)
    //     return 0;
    //     else
    //     {
    //         if(x.Count()>y.Count())
    //         return 1;
    //         else if(x.Count()<y.Count())
    //         return -1;
    //         else
    //         {
    //             return x.CompareTo(y);
    //         }
    //     }
    // }
}