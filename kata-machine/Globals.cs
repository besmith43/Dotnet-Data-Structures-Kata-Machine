using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kata_machine;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class ListNode<T>
{
    public T Value { get; set; }
    public ListNode<T>? Next { get; set; }
    public ListNode<T>? Prev { get; set; }
}

public interface List<T>
{
    void Prepend(T value);
    void InsertAt(int index, T value);
    void Append(T value);
    T? Remove(T value);
    T? Get(int index);
    T? RemoveAt(int index);
    int Length();
}

public class CompleteGraphEdge
{
    public int From { get; set; }
    public int To { get; set; }
    public int Weight { get; set; }
}

public class GraphEdge
{
    public int To { get; set; }
    public int Weight { get; set; }
}

public class WeightedAdjacencyList
{
    public List<GraphEdge>[] Edges { get; set; }
}

public class WeightedAdjacencyMatrix
{
    public int[,] Matrix { get; set; }
}

public class AdjacencyList
{
    public List<int>[] Edges { get; set; }
}

public class AdjacencyMatrix
{
    public int[,] Matrix { get; set; }
}

public class BinaryNode<T>
{
    public T Value { get; set; }
    public BinaryNode<T>? Left { get; set; }
    public BinaryNode<T>? Right { get; set; }
}

public class GeneralNode<T>
{
    public T Value { get; set; }
    public List<GeneralNode<T>> Children { get; set; }
}

public interface ILRU<TKey, TValue>
{
    void Update(TKey key, TValue value);
    TValue? Get(TKey key);
}