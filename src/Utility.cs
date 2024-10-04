namespace S2BU
{
    /// <summary>Contains utility methods and helper functions</summary>
    public class Utility
    {
        /// <summary>Returns the Endianess of the host machine</summary>
        public static Endianess GetEndianess()
        {
            return Endianess.bigEndian;
        }

        /// <summary>Converts a given byte sequence from BE to LE</summary>
        public static void ConvertToLittleEndian()
        {
            //TODO: Implementation
        }

        /// <summary>Converts a given byte sequence from LE to BE</summary>
        public static void ConvertToBigEndian()
        {
            //TODO: Implemetation
        }
    }
}
