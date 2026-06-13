namespace Indexator;

public class Function
{
    //public int[,] func { get; set; }
    public int[] X { get; set; }
    public int[] Y { get; set; }
    
    //int this[int i, int j] => func[i, j];
    int this[int i, int j] => X[i] + Y[j];
    
    
}