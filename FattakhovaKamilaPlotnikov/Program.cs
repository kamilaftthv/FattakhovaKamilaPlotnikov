class ChessPiece
{
    public int x { get; set; }
    public int y { get; set; }
    public virtual bool Move(int newX, int newY)
    {
        return false;
    }
}

class Pawn : ChessPiece
{
    public Pawn(int startX, int startY)
    {
        x = startX;
        y = startY;
    }
    public override bool Move(int newX, int newY)
    {
        int newwwX = newX - x;
        int newwwY = newY - y;

        if ((newwwX == 0 && newwwY == 1) || (newwwX == 0 && newwwY == 2))
        {
            Console.WriteLine("Пешка ходит на координаты ({0}, {1})", newX, newY);
            x = newX;
            y = newY;
            return true;
        }
        else
        {
            Console.WriteLine("Пешка не может сходить на данные координаты");
            return false;
        }
    }
}

class King : ChessPiece
{
    public King(int startX, int startY)
    {
        x = startX; 
        y = startY;
    }
    public override bool Move(int newX, int newY)
    {
        int newwwX = newX - x;
        int newwwY = newY - y;
        
        if (newwwX <= 1 && newwwY <= 1)
        {
            Console.WriteLine("Король ходит на координаты ({0}, {1})", newX, newY);
            x = newX;
            y = newY;
            return true;
        }
        else
        {
            Console.WriteLine("Король не может сходить на данные координаты");
            return false;
        }
    }
}

class Ferz : ChessPiece
{
    public Ferz(int startX, int startY)
    {
        x = startX; 
        y = startY;
    }
    public override bool Move(int newX, int newY)
    {
        int newwwX = newX - x;
        int newwwY = newY - y;

        if (newwwX == 0 || newwwY == 0 || newwwX == newwwY)
        {
            Console.WriteLine("Ферзь ходит на координаты ({0}, {1})", newX, newY);
            x = newX;
            y = newY;
            return true;
        }
        else
        {
            Console.WriteLine("Ферзь не может сходить на данные координаты");
            return false;
        }
    }
}

class Ladiya : ChessPiece
{
    public Ladiya(int startX, int startY)
    {
        x = startX; 
        y = startY;
    }
    public override bool Move(int newX, int newY)
    {
        int newwwX = newX - x;
        int newwwY = newY - y;

        if (newwwX == 0 || newwwY == 0)
        {
            Console.WriteLine("Ладья ходит на координаты ({0}, {1})", newX, newY);
            x = newX;
            y = newY;
            return true;
        }
        else
        {
            Console.WriteLine("Ладья не может сходить на данные координаты");
            return false;
        }
    }
}

class Slon : ChessPiece
{
    public Slon(int startX, int startY)
    {
        x = startX; 
        y = startY;
    }
    public override bool Move(int newX, int newY)
    {
        int newwwX = newX - x;
        int newwwY = newY - y;

        if (newwwX == newwwY)
        {
            Console.WriteLine("Слон ходит на координаты ({0}, {1})", newX, newY);
            x = newX;
            y = newY;
            return true;
        }
        else
        {
            Console.WriteLine("Слон не может сходить на данные координаты");
            return false;
        }
    }
}

class Kon : ChessPiece
{
    public Kon(int startX, int startY)
    {
        x = startX; 
        y = startY;
    }
    public override bool Move(int newX, int newY)
    {
        int newwwX = newX - x;
        int newwwY = newY - y;

        if ((newwwX == 2 && newwwY == 1) || (newwwX == 1 && newwwY == 2))
        {
            Console.WriteLine("Конь ходит на координаты ({0}, {1})", newX, newY);
            x = newX;
            y = newY;
            return true;
        }
        else
        {
            Console.WriteLine("Конь не может сходить на данные координаты");
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Все фигуры находятся на координатах(1, 1)");
        Console.WriteLine("Выберите фигуру (1-Король, 2-Ферзь, 3-Ладья, 4-Слон, 5-Конь, 6-Пешка):");
        int fig = int.Parse(Console.ReadLine());
        ChessPiece chessPiece = null;
        if (fig == 1)
        {
            chessPiece = new King(1, 1); 
        }
        else if (fig == 2)
        {
            chessPiece = new Ferz(1, 1); 
        }
        else if (fig == 3)
        {
            chessPiece = new Ladiya(1, 1);
        }
        else if (fig == 4)
        {
            chessPiece = new Slon(1, 1);
        }
        else if (fig == 5)
        {
            chessPiece = new Kon(1, 1);
        }
        else if (fig == 6)
        {
            chessPiece = new Pawn(1, 1);
        }

        if (chessPiece != null)
        {
            Console.Write("Новые координаты X: ");
            int newX = int.Parse(Console.ReadLine());
            Console.Write("Новые координаты Y: ");
            int newY = int.Parse(Console.ReadLine());
            chessPiece.Move(newX, newY);
        }
    }
}