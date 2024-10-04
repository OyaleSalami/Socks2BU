namespace S2BU
{
    /// <summary>Describes the order in which bytes are stored</summary>
    public enum Endianess
    {
        /// <summary>Most significant byte starts at the lower storage address</summary>
        bigEndian,
        /// <summary>Least significant byte starts at the lower storage address</summary>
        littleEndian
    }

    /// <summary>Describes what transport protocol is being used</summary>
    public enum Transport
    {
        /// <summary>Broadcast to all computers on a network</summary>
        Multicast,
        /// <summary>The TCP transport protocol</summary>
        TCP,
        /// <summary>The UDP transport protocol</summary>
        UDP,
        /// <summary>The UDP transport protocol (Reliable)</summary>
        UDPReliable
    }

    
}
