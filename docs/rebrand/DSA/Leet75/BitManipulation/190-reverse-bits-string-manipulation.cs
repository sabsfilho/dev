public class Solution {
    public uint reverseBits(uint n) {
        var bits= string.Join(string.Empty,
                Convert.ToString(n, 2).PadLeft(32, '0')
                    .Select(c => int.Parse(c.ToString()))
                    .Reverse()
                );

        return Convert.ToUInt32(bits, 2);

    }
}