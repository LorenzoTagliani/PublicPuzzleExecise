using System;

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    public Direction Direction { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public RobotSimulator(Direction direction, int x, int y)
    {
        this.Direction = direction;
        this.X = x;
        this.Y = y;
    }

    public void Move(string instructions)
    {
        // Splitto la mia stringa in una lista di char
        var instructionCharArray = instructions.ToCharArray();

        foreach (var c in instructionCharArray)
        {
            switch (c)
            {
                case 'A':
                    Advance();
                    break;
                case 'R':
                    RotateRight();
                    break;
                case 'L':
                    RotateLeft();
                    break;
            }
        }

        return;
    }

    public void Advance()
    {
        switch (this.Direction)
        {
            case Direction.North:
                this.Y++;
                break;
            case Direction.East:
                this.X++;
                break;
            case Direction.South:
                this.Y--;
                break;
            case Direction.West:
                this.X--;
                break;
        }
    }

    public void RotateRight()
    {
        switch (this.Direction)
        {
            case Direction.North:
            this.Direction = Direction.East;
                break;
            case Direction.East:
            this.Direction = Direction.South;
                break;
            case Direction.South:
            this.Direction = Direction.West;
                break;
            case Direction.West:
            this.Direction = Direction.North;
                break;
        }
    }

    
    public void RotateLeft()
    {
        switch (this.Direction)
        {
            case Direction.North:
            this.Direction = Direction.West;
                break;
            case Direction.West:
            this.Direction = Direction.South;
                break;
            case Direction.South:
            this.Direction = Direction.East;
                break;
            case Direction.East:
            this.Direction = Direction.North;
                break;
        }
    }
}


