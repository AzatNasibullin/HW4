public class Bits
{
    private string binaryRepresentation;

    public Bits(string binary)
    {
        this.binaryRepresentation = binary;
    }

    public override string ToString()
    {
        return binaryRepresentation;
    }

    //long в Bits
    public static explicit operator Bits(long value)
    {
        return new Bits(Convert.ToString(value, 2));
    }

    // int в Bits
    public static explicit operator Bits(int value)
    {
        return new Bits(Convert.ToString(value, 2));
    }

    // byte в Bits
    public static explicit operator Bits(byte value)
    {
        return new Bits(Convert.ToString(value, 2));
    }

    // long в Bits
    public static implicit operator Bits(uint value)
    {
        return new Bits(Convert.ToString(value, 2));
    }
}

class Program
{
    static void Main(string[] args)
    {
        long longValue = 1234567890123456789;
        int intValue = 123456789;
        byte byteValue = 123;

        // Явное приведение
        Bits bitsFromLong = (Bits)longValue;
        Bits bitsFromInt = (Bits)intValue;
        Bits bitsFromByte = (Bits)byteValue;

        // Неявное приведение
        Bits bitsFromUInt = uint.MaxValue;

        Console.WriteLine($"long: {bitsFromLong}");
        Console.WriteLine($"int: {bitsFromInt}");
        Console.WriteLine($"byte: {bitsFromByte}");
        Console.WriteLine($"uint: {bitsFromUInt}");
    }
}