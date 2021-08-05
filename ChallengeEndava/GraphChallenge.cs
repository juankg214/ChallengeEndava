using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChallengeEndava
{

    public class Edge
    {
        public int Source { get; set; }
        public int Dest { get; set; }
        public int Weight { get; set; }

        public Edge(int src, int dest, int weight)
        {
            this.Source = src;
            this.Dest = dest;
            this.Weight = weight;
        }
    }

    class GraphChallenge
    {

        List<List<int>> AdjList { get; set; }
        public int V { get; set; }
        public List<List<int>> Path { get; set; } = new List<List<int>>();
        public int[,] PathFloyd;

        private bool FloydCalled = false;

        public bool[,] Visited;

        public int[,] AdjMatrix;
        int[,] dist;

        public GraphChallenge(List<Edge> edges, int V)
        {
            this.V = V;
            AdjList = new List<List<int>>();
            AdjMatrix = new int[V, V];
            PathFloyd = new int[V, V];

            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    if (i != j)
                    {
                        AdjMatrix[i, j] = Int32.MaxValue;
                    }
                }
            }

            for (int i = 0; i < V; i++)
            {
                AdjList.Add(new List<int>());
                Path.Add(new List<int>());
            }

            foreach (var edge in edges)
            {
                int src = edge.Source;
                int dest = edge.Dest;

                AdjList[src].Add(dest);
                AdjList[dest].Add(src);

                AdjMatrix[src, dest] = edge.Weight;
                AdjMatrix[dest, src] = edge.Weight;
            }

            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    if (AdjMatrix[i, j] == Int32.MaxValue)
                    {
                        PathFloyd[i, j] = -1;
                    }
                    else
                    {
                        PathFloyd[i, j] = j;
                    }
                }
            }

            dist = (int[,])AdjMatrix.Clone();

        }




        private void PrintArray(List<int> arr)
        {
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
        }

        private string PrintAsRoad(List<int> arr)
        {
            string aux = "";
            foreach (var i in arr)
            {
                aux += "n" + (i + 1) + " -> ";
            }

            return aux.Remove(aux.Length - 3);
        }

        private int GetWeightOfRoad(List<int> arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                sum += AdjMatrix[arr[i], arr[i + 1]];
            }

            return sum;
        }

        private List<int> GetBestRoad(List<List<int>> arr)
        {
            int bestIndex = 0;
            int Bestweight = Int32.MaxValue;
            int aux;
            for (int i = 0; i < arr.Count; i++)
            {
                aux = GetWeightOfRoad(arr[i]);
                if (aux < Bestweight)
                {
                    Bestweight = aux;
                    bestIndex = i;
                }
            }

            return arr[bestIndex];
        }

        private void GetHamiltonianPaths(int nodo, List<List<int>> Founded, int i)
        {

            if (Path[i].Count == V)
            {
                Founded.Add(new List<int>(Path[i]));
            }

            foreach (int n in AdjList[nodo])
            {
                if (!Visited[i, n])
                {
                    Visited[i, n] = true;
                    Path[i].Add(n);
                    GetHamiltonianPaths(n, Founded, i);
                    Visited[i, n] = false;
                    Path[i].RemoveAt(Path[i].Count - 1);
                }
            }

        }

        public (string, string) PrimerPunto()
        {

            List<List<int>> Best = new List<List<int>>();
            Visited = new bool[V, V];
            List<List<List<int>>> Founded = new List<List<List<int>>>();
            Path = new List<List<int>>();

            for (int i = 0; i < V; i++)
            {
                Founded.Add(new List<List<int>>());
                Path.Add(new List<int>());
            }

            bool flag = false;

            for (int i = 0; i < V; i++)
            {
                Visited[i, i] = true;
                Path[i].Add(i);
                GetHamiltonianPaths(i, Founded[i], i);
                if (Founded[i].Count > 0)
                {
                    flag = true;
                    var sol = GetBestRoad(Founded[i]);
                    int w = GetWeightOfRoad(sol);
                    Best.Add(sol);
                }

            }

            var found = GetBestRoad(Best);

            if (flag)
            {
                return (PrintAsRoad(found), GetWeightOfRoad(found).ToString());
            }
            else
            {
                return ("Not Solution Found !!!", "");
            }

        }

        public (string, string, string) PrimerPuntoParalelo()
        {

            List<List<int>> Best = new List<List<int>>();
            Visited = new bool[V, V];
            List<List<List<int>>> Founded = new List<List<List<int>>>();
            Path = new List<List<int>>();
            ConcurrentBag<int> threadIDs = new ConcurrentBag<int>();
            for (int i = 0; i < V; i++)
            {
                Founded.Add(new List<List<int>>());
                Path.Add(new List<int>());
            }

            bool flag = false;

            Parallel.For(0, V, i =>
            {
                threadIDs.Add(Thread.CurrentThread.ManagedThreadId);
                Visited[i, i] = true;
                Path[i].Add(i);
                GetHamiltonianPaths(i, Founded[i], i);
                if (Founded[i].Count > 0)
                {
                    flag = true;
                    var sol = GetBestRoad(Founded[i]);
                    int w = GetWeightOfRoad(sol);
                    Best.Add(sol);
                }

            });

            var found = GetBestRoad(Best);

            if (flag)
            {
                return (PrintAsRoad(found), GetWeightOfRoad(found).ToString(), threadIDs.Distinct().Count().ToString());
            }
            else
            {
                return ("Not Solution Found !!!", "", " ");
            }
        }

        private void FloydWarshall()
        {

            FloydCalled = true;

            for (int k = 0; k < V; k++)
            {
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {
                        if (!(dist[i, k] == Int32.MaxValue || dist[k, j] == Int32.MaxValue))
                        {
                            int aux = dist[i, k] + dist[k, j];
                            if (dist[i, j] > aux)
                            {
                                dist[i, j] = aux;
                                PathFloyd[i, j] = PathFloyd[i, k];
                            }
                        }
                    }
                }
            }
        }

        private List<int> GetPath(int u, int v)
        {

            if (PathFloyd[u, v] == -1)
                return null;

            List<int> path = new List<int>();
            path.Add(u);

            while (u != v)
            {
                u = PathFloyd[u, v];
                path.Add(u);
            }
            return path;
        }

        public (string, string) SegundoPunto(int u, int v)
        {
            if (!FloydCalled)
            {
                FloydWarshall();
            }


            var val = GetPath(u, v);
            if (val != null)
            {
                return (PrintAsRoad(val), dist[u, v].ToString());
            }
            else
            {
                return ("Not Solution Found !!!", "");
            }

        }
    }
}
