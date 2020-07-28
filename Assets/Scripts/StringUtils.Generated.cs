using System;
using System.Text;

public class StringUtils 
{
    public static string Concat<T1>(T1 v1)
    {
        var sb = new StringBuilder();
        sb.Append(v1);
        return sb.ToString();
    }

    public static string Concat<T1, T2>(T1 v1, T2 v2)
    {
        var sb = new StringBuilder();
        sb.Append(v1).Append(v2);
        return sb.ToString();
    }

    public static string Concat<T1, T2, T3>(T1 v1, T2 v2, T3 v3)
    {
        var sb = new StringBuilder();
        sb.Append(v1).Append(v2).Append(v3);
        return sb.ToString();
    }

    public static string Concat<T1, T2, T3, T4>(T1 v1, T2 v2, T3 v3, T4 v4)
    {
        var sb = new StringBuilder();
        sb.Append(v1).Append(v2).Append(v3).Append(v4);
        return sb.ToString();
    }

    public static string Concat<T1, T2, T3, T4, T5>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5)
    {
        var sb = new StringBuilder();
        sb.Append(v1).Append(v2).Append(v3).Append(v4).Append(v5);
        return sb.ToString();
    }

    public static string Concat<T1, T2, T3, T4, T5, T6>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6)
    {
        var sb = new StringBuilder();
        sb.Append(v1).Append(v2).Append(v3).Append(v4).Append(v5).Append(v6);
        return sb.ToString();
    }

    public static string Concat<T1, T2, T3, T4, T5, T6, T7>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7)
    {
        var sb = new StringBuilder();
        sb.Append(v1).Append(v2).Append(v3).Append(v4).Append(v5).Append(v6).Append(v7);
        return sb.ToString();
    }

    public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8)
    {
        var sb = new StringBuilder();
        sb.Append(v1).Append(v2).Append(v3).Append(v4).Append(v5).Append(v6).Append(v7).Append(v8);
        return sb.ToString();
    }

    
}