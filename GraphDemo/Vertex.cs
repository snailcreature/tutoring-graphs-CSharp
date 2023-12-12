using System.ComponentModel.DataAnnotations;

namespace GraphDemo;

public class Vertex
{
    private int id;
    private int value;

    private List<Vertex> Arcs;

    public Vertex(int id, int value)
    {
        this.id = id;
        this.value = value;
    }

    public int GetId()
    {
        return this.id;
    }

    public int GetValue()
    {
        return this.value;
    }

    public void AddArc(Vertex arcTo)
    {
        this.Arcs.Add(arcTo);
        arcTo.AddArcDirected(this);
    }

    public void AddArcDirected(Vertex arcTo)
    {
        this.Arcs.Add(arcTo);
    }

    public List<Vertex> GetVertices()
    {
        return this.Arcs;
    }
}
