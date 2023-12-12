// See https://aka.ms/new-console-template for more information
using GraphDemo;

Console.WriteLine("Declaring vertices...");

Vertex vertexA = new Vertex(0, 10);
Vertex vertexB = new Vertex(1, 42);
Vertex vertexC = new Vertex(2, 92);
Vertex vertexD = new Vertex(3,  3);
Vertex vertexE = new Vertex(4, 47);

Console.WriteLine("Connecting them together...");

vertexA.AddArc(ref vertexB);
vertexA.AddArc(ref vertexE);

vertexB.AddArc(ref vertexD);
vertexB.AddArc(ref vertexC);

vertexC.AddArc(ref vertexA);

Console.WriteLine("Creating Walker...");

Walker walker = new Walker(vertexA);

Console.WriteLine("Let's get walking!");

walker.PrintCurrentVertex();

walker.WalkTo(vertexE);
walker.PrintCurrentVertex();