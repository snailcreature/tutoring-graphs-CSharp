namespace GraphDemo;

public class Walker
{
    private Vertex CurrentVertex;

    public Walker(Vertex startVertex)
    {
        this.CurrentVertex = startVertex;
    }

    public void PrintCurrentVertex()
    {
        Console.WriteLine($"{this.CurrentVertex.GetId}: {this.CurrentVertex.GetValue}");
    }

    public bool WalkTo(Vertex vertex)
    {
        if (this.CurrentVertex.GetVertices().Contains(vertex))
        {
            this.CurrentVertex = vertex;
            return true;
        }

        return false;
    }
}
