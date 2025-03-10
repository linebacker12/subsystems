using System;
using System.Text;
using System.Linq;

namespace EulynxLive.Messages.Baseline4R1;

public record AdjacentInterlockingSystemPdiVersionCheckCommand (string SenderIdentifier, string ReceiverIdentifier, byte PdiVersionOfSender) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int PdiVersionOfSenderOffset = 43;
    public static readonly ushort MessageType = 0x0024;

    public new static AdjacentInterlockingSystemPdiVersionCheckCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var PdiVersionOfSender = (byte)message[PdiVersionOfSenderOffset];
        return new AdjacentInterlockingSystemPdiVersionCheckCommand(SenderIdentifier, ReceiverIdentifier, PdiVersionOfSender);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.AdjacentInterlockingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[PdiVersionOfSenderOffset] = (byte)PdiVersionOfSender;
        return result;
    }
}




public record TrainDetectionSystemPdiVersionCheckCommand (string SenderIdentifier, string ReceiverIdentifier, byte PdiVersionOfSender) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int PdiVersionOfSenderOffset = 43;
    public static readonly ushort MessageType = 0x0024;

    public new static TrainDetectionSystemPdiVersionCheckCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var PdiVersionOfSender = (byte)message[PdiVersionOfSenderOffset];
        return new TrainDetectionSystemPdiVersionCheckCommand(SenderIdentifier, ReceiverIdentifier, PdiVersionOfSender);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.TrainDetectionSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[PdiVersionOfSenderOffset] = (byte)PdiVersionOfSender;
        return result;
    }
}




public record LightSignalPdiVersionCheckCommand (string SenderIdentifier, string ReceiverIdentifier, byte PdiVersionOfSender) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int PdiVersionOfSenderOffset = 43;
    public static readonly ushort MessageType = 0x0024;

    public new static LightSignalPdiVersionCheckCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var PdiVersionOfSender = (byte)message[PdiVersionOfSenderOffset];
        return new LightSignalPdiVersionCheckCommand(SenderIdentifier, ReceiverIdentifier, PdiVersionOfSender);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.LightSignal;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[PdiVersionOfSenderOffset] = (byte)PdiVersionOfSender;
        return result;
    }
}




public record PointPdiVersionCheckCommand (string SenderIdentifier, string ReceiverIdentifier, byte PdiVersionOfSender) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int PdiVersionOfSenderOffset = 43;
    public static readonly ushort MessageType = 0x0024;

    public new static PointPdiVersionCheckCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var PdiVersionOfSender = (byte)message[PdiVersionOfSenderOffset];
        return new PointPdiVersionCheckCommand(SenderIdentifier, ReceiverIdentifier, PdiVersionOfSender);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.Point;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[PdiVersionOfSenderOffset] = (byte)PdiVersionOfSender;
        return result;
    }
}




public record RadioBlockCenterPdiVersionCheckCommand (string SenderIdentifier, string ReceiverIdentifier, byte PdiVersionOfSender) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int PdiVersionOfSenderOffset = 43;
    public static readonly ushort MessageType = 0x0024;

    public new static RadioBlockCenterPdiVersionCheckCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var PdiVersionOfSender = (byte)message[PdiVersionOfSenderOffset];
        return new RadioBlockCenterPdiVersionCheckCommand(SenderIdentifier, ReceiverIdentifier, PdiVersionOfSender);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.RadioBlockCenter;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[PdiVersionOfSenderOffset] = (byte)PdiVersionOfSender;
        return result;
    }
}




public record LevelCrossingPdiVersionCheckCommand (string SenderIdentifier, string ReceiverIdentifier, byte PdiVersionOfSender) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int PdiVersionOfSenderOffset = 43;
    public static readonly ushort MessageType = 0x0024;

    public new static LevelCrossingPdiVersionCheckCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var PdiVersionOfSender = (byte)message[PdiVersionOfSenderOffset];
        return new LevelCrossingPdiVersionCheckCommand(SenderIdentifier, ReceiverIdentifier, PdiVersionOfSender);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.LevelCrossing;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[PdiVersionOfSenderOffset] = (byte)PdiVersionOfSender;
        return result;
    }
}




public record CCPdiVersionCheckCommand (string SenderIdentifier, string ReceiverIdentifier, byte PdiVersionOfSender) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int PdiVersionOfSenderOffset = 43;
    public static readonly ushort MessageType = 0x0024;

    public new static CCPdiVersionCheckCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var PdiVersionOfSender = (byte)message[PdiVersionOfSenderOffset];
        return new CCPdiVersionCheckCommand(SenderIdentifier, ReceiverIdentifier, PdiVersionOfSender);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.CC;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[PdiVersionOfSenderOffset] = (byte)PdiVersionOfSender;
        return result;
    }
}




public record GenericIOPdiVersionCheckCommand (string SenderIdentifier, string ReceiverIdentifier, byte PdiVersionOfSender) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int PdiVersionOfSenderOffset = 43;
    public static readonly ushort MessageType = 0x0024;

    public new static GenericIOPdiVersionCheckCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var PdiVersionOfSender = (byte)message[PdiVersionOfSenderOffset];
        return new GenericIOPdiVersionCheckCommand(SenderIdentifier, ReceiverIdentifier, PdiVersionOfSender);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.GenericIO;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[PdiVersionOfSenderOffset] = (byte)PdiVersionOfSender;
        return result;
    }
}




public record ExternalLevelCrossingSystemPdiVersionCheckCommand (string SenderIdentifier, string ReceiverIdentifier, byte PdiVersionOfSender) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int PdiVersionOfSenderOffset = 43;
    public static readonly ushort MessageType = 0x0024;

    public new static ExternalLevelCrossingSystemPdiVersionCheckCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var PdiVersionOfSender = (byte)message[PdiVersionOfSenderOffset];
        return new ExternalLevelCrossingSystemPdiVersionCheckCommand(SenderIdentifier, ReceiverIdentifier, PdiVersionOfSender);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.ExternalLevelCrossingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[PdiVersionOfSenderOffset] = (byte)PdiVersionOfSender;
        return result;
    }
}





public record AdjacentInterlockingSystemInitialisationRequestCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0021;

    public new static AdjacentInterlockingSystemInitialisationRequestCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new AdjacentInterlockingSystemInitialisationRequestCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.AdjacentInterlockingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record TrainDetectionSystemInitialisationRequestCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0021;

    public new static TrainDetectionSystemInitialisationRequestCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new TrainDetectionSystemInitialisationRequestCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.TrainDetectionSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LightSignalInitialisationRequestCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0021;

    public new static LightSignalInitialisationRequestCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LightSignalInitialisationRequestCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LightSignal;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record PointInitialisationRequestCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0021;

    public new static PointInitialisationRequestCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new PointInitialisationRequestCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.Point;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record RadioBlockCenterInitialisationRequestCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0021;

    public new static RadioBlockCenterInitialisationRequestCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new RadioBlockCenterInitialisationRequestCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.RadioBlockCenter;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LevelCrossingInitialisationRequestCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0021;

    public new static LevelCrossingInitialisationRequestCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LevelCrossingInitialisationRequestCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LevelCrossing;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record CCInitialisationRequestCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0021;

    public new static CCInitialisationRequestCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new CCInitialisationRequestCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.CC;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record GenericIOInitialisationRequestCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0021;

    public new static GenericIOInitialisationRequestCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new GenericIOInitialisationRequestCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.GenericIO;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record ExternalLevelCrossingSystemInitialisationRequestCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0021;

    public new static ExternalLevelCrossingSystemInitialisationRequestCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new ExternalLevelCrossingSystemInitialisationRequestCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.ExternalLevelCrossingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record AdjacentInterlockingSystemStartInitialisationMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0022;

    public new static AdjacentInterlockingSystemStartInitialisationMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new AdjacentInterlockingSystemStartInitialisationMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.AdjacentInterlockingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record TrainDetectionSystemStartInitialisationMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0022;

    public new static TrainDetectionSystemStartInitialisationMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new TrainDetectionSystemStartInitialisationMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.TrainDetectionSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LightSignalStartInitialisationMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0022;

    public new static LightSignalStartInitialisationMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LightSignalStartInitialisationMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LightSignal;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record PointStartInitialisationMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0022;

    public new static PointStartInitialisationMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new PointStartInitialisationMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.Point;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record RadioBlockCenterStartInitialisationMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0022;

    public new static RadioBlockCenterStartInitialisationMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new RadioBlockCenterStartInitialisationMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.RadioBlockCenter;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LevelCrossingStartInitialisationMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0022;

    public new static LevelCrossingStartInitialisationMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LevelCrossingStartInitialisationMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LevelCrossing;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record CCStartInitialisationMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0022;

    public new static CCStartInitialisationMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new CCStartInitialisationMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.CC;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record GenericIOStartInitialisationMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0022;

    public new static GenericIOStartInitialisationMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new GenericIOStartInitialisationMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.GenericIO;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record ExternalLevelCrossingSystemStartInitialisationMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0022;

    public new static ExternalLevelCrossingSystemStartInitialisationMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new ExternalLevelCrossingSystemStartInitialisationMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.ExternalLevelCrossingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record AdjacentInterlockingSystemStatusReportCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0026;

    public new static AdjacentInterlockingSystemStatusReportCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new AdjacentInterlockingSystemStatusReportCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.AdjacentInterlockingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record TrainDetectionSystemStatusReportCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0026;

    public new static TrainDetectionSystemStatusReportCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new TrainDetectionSystemStatusReportCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.TrainDetectionSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LightSignalStatusReportCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0026;

    public new static LightSignalStatusReportCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LightSignalStatusReportCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LightSignal;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record PointStatusReportCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0026;

    public new static PointStatusReportCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new PointStatusReportCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.Point;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record RadioBlockCenterStatusReportCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0026;

    public new static RadioBlockCenterStatusReportCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new RadioBlockCenterStatusReportCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.RadioBlockCenter;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LevelCrossingStatusReportCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0026;

    public new static LevelCrossingStatusReportCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LevelCrossingStatusReportCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LevelCrossing;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record CCStatusReportCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0026;

    public new static CCStatusReportCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new CCStatusReportCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.CC;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record GenericIOStatusReportCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0026;

    public new static GenericIOStatusReportCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new GenericIOStatusReportCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.GenericIO;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record ExternalLevelCrossingSystemStatusReportCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0026;

    public new static ExternalLevelCrossingSystemStatusReportCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new ExternalLevelCrossingSystemStatusReportCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.ExternalLevelCrossingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record AdjacentInterlockingSystemInitialisationCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0023;

    public new static AdjacentInterlockingSystemInitialisationCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new AdjacentInterlockingSystemInitialisationCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.AdjacentInterlockingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record TrainDetectionSystemInitialisationCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0023;

    public new static TrainDetectionSystemInitialisationCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new TrainDetectionSystemInitialisationCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.TrainDetectionSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LightSignalInitialisationCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0023;

    public new static LightSignalInitialisationCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LightSignalInitialisationCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LightSignal;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record PointInitialisationCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0023;

    public new static PointInitialisationCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new PointInitialisationCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.Point;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record RadioBlockCenterInitialisationCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0023;

    public new static RadioBlockCenterInitialisationCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new RadioBlockCenterInitialisationCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.RadioBlockCenter;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LevelCrossingInitialisationCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0023;

    public new static LevelCrossingInitialisationCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LevelCrossingInitialisationCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LevelCrossing;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record CCInitialisationCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0023;

    public new static CCInitialisationCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new CCInitialisationCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.CC;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record GenericIOInitialisationCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0023;

    public new static GenericIOInitialisationCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new GenericIOInitialisationCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.GenericIO;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record ExternalLevelCrossingSystemInitialisationCompletedMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0023;

    public new static ExternalLevelCrossingSystemInitialisationCompletedMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new ExternalLevelCrossingSystemInitialisationCompletedMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.ExternalLevelCrossingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record AdjacentInterlockingSystemClosePdiCommand (string SenderIdentifier, string ReceiverIdentifier, AdjacentInterlockingSystemClosePdiCommandCloseReason CloseReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int CloseReasonOffset = 43;
    public static readonly ushort MessageType = 0x0027;

    public new static AdjacentInterlockingSystemClosePdiCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var CloseReason = (AdjacentInterlockingSystemClosePdiCommandCloseReason)message[CloseReasonOffset];
        return new AdjacentInterlockingSystemClosePdiCommand(SenderIdentifier, ReceiverIdentifier, CloseReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.AdjacentInterlockingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[CloseReasonOffset] = (byte)CloseReason;
        return result;
    }
}

public enum AdjacentInterlockingSystemClosePdiCommandCloseReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03,
    NormalClose = 0x04,
    OtherVersionRequired = 0x05,
    Timeout = 0x06,
    ChecksumMismatch = 0x07
}


public record TrainDetectionSystemClosePdiCommand (string SenderIdentifier, string ReceiverIdentifier, TrainDetectionSystemClosePdiCommandCloseReason CloseReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int CloseReasonOffset = 43;
    public static readonly ushort MessageType = 0x0027;

    public new static TrainDetectionSystemClosePdiCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var CloseReason = (TrainDetectionSystemClosePdiCommandCloseReason)message[CloseReasonOffset];
        return new TrainDetectionSystemClosePdiCommand(SenderIdentifier, ReceiverIdentifier, CloseReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.TrainDetectionSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[CloseReasonOffset] = (byte)CloseReason;
        return result;
    }
}

public enum TrainDetectionSystemClosePdiCommandCloseReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03,
    NormalClose = 0x04,
    OtherVersionRequired = 0x05,
    Timeout = 0x06,
    ChecksumMismatch = 0x07
}


public record LightSignalClosePdiCommand (string SenderIdentifier, string ReceiverIdentifier, LightSignalClosePdiCommandCloseReason CloseReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int CloseReasonOffset = 43;
    public static readonly ushort MessageType = 0x0027;

    public new static LightSignalClosePdiCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var CloseReason = (LightSignalClosePdiCommandCloseReason)message[CloseReasonOffset];
        return new LightSignalClosePdiCommand(SenderIdentifier, ReceiverIdentifier, CloseReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.LightSignal;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[CloseReasonOffset] = (byte)CloseReason;
        return result;
    }
}

public enum LightSignalClosePdiCommandCloseReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03,
    NormalClose = 0x04,
    OtherVersionRequired = 0x05,
    Timeout = 0x06,
    ChecksumMismatch = 0x07
}


public record PointClosePdiCommand (string SenderIdentifier, string ReceiverIdentifier, PointClosePdiCommandCloseReason CloseReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int CloseReasonOffset = 43;
    public static readonly ushort MessageType = 0x0027;

    public new static PointClosePdiCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var CloseReason = (PointClosePdiCommandCloseReason)message[CloseReasonOffset];
        return new PointClosePdiCommand(SenderIdentifier, ReceiverIdentifier, CloseReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.Point;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[CloseReasonOffset] = (byte)CloseReason;
        return result;
    }
}

public enum PointClosePdiCommandCloseReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03,
    NormalClose = 0x04,
    OtherVersionRequired = 0x05,
    Timeout = 0x06,
    ChecksumMismatch = 0x07
}


public record RadioBlockCenterClosePdiCommand (string SenderIdentifier, string ReceiverIdentifier, RadioBlockCenterClosePdiCommandCloseReason CloseReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int CloseReasonOffset = 43;
    public static readonly ushort MessageType = 0x0027;

    public new static RadioBlockCenterClosePdiCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var CloseReason = (RadioBlockCenterClosePdiCommandCloseReason)message[CloseReasonOffset];
        return new RadioBlockCenterClosePdiCommand(SenderIdentifier, ReceiverIdentifier, CloseReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.RadioBlockCenter;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[CloseReasonOffset] = (byte)CloseReason;
        return result;
    }
}

public enum RadioBlockCenterClosePdiCommandCloseReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03,
    NormalClose = 0x04,
    OtherVersionRequired = 0x05,
    Timeout = 0x06,
    ChecksumMismatch = 0x07
}


public record LevelCrossingClosePdiCommand (string SenderIdentifier, string ReceiverIdentifier, LevelCrossingClosePdiCommandCloseReason CloseReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int CloseReasonOffset = 43;
    public static readonly ushort MessageType = 0x0027;

    public new static LevelCrossingClosePdiCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var CloseReason = (LevelCrossingClosePdiCommandCloseReason)message[CloseReasonOffset];
        return new LevelCrossingClosePdiCommand(SenderIdentifier, ReceiverIdentifier, CloseReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.LevelCrossing;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[CloseReasonOffset] = (byte)CloseReason;
        return result;
    }
}

public enum LevelCrossingClosePdiCommandCloseReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03,
    NormalClose = 0x04,
    OtherVersionRequired = 0x05,
    Timeout = 0x06,
    ChecksumMismatch = 0x07
}


public record CCClosePdiCommand (string SenderIdentifier, string ReceiverIdentifier, CCClosePdiCommandCloseReason CloseReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int CloseReasonOffset = 43;
    public static readonly ushort MessageType = 0x0027;

    public new static CCClosePdiCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var CloseReason = (CCClosePdiCommandCloseReason)message[CloseReasonOffset];
        return new CCClosePdiCommand(SenderIdentifier, ReceiverIdentifier, CloseReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.CC;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[CloseReasonOffset] = (byte)CloseReason;
        return result;
    }
}

public enum CCClosePdiCommandCloseReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03,
    NormalClose = 0x04,
    OtherVersionRequired = 0x05,
    Timeout = 0x06,
    ChecksumMismatch = 0x07
}


public record GenericIOClosePdiCommand (string SenderIdentifier, string ReceiverIdentifier, GenericIOClosePdiCommandCloseReason CloseReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int CloseReasonOffset = 43;
    public static readonly ushort MessageType = 0x0027;

    public new static GenericIOClosePdiCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var CloseReason = (GenericIOClosePdiCommandCloseReason)message[CloseReasonOffset];
        return new GenericIOClosePdiCommand(SenderIdentifier, ReceiverIdentifier, CloseReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.GenericIO;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[CloseReasonOffset] = (byte)CloseReason;
        return result;
    }
}

public enum GenericIOClosePdiCommandCloseReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03,
    NormalClose = 0x04,
    OtherVersionRequired = 0x05,
    Timeout = 0x06,
    ChecksumMismatch = 0x07
}


public record ExternalLevelCrossingSystemClosePdiCommand (string SenderIdentifier, string ReceiverIdentifier, ExternalLevelCrossingSystemClosePdiCommandCloseReason CloseReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int CloseReasonOffset = 43;
    public static readonly ushort MessageType = 0x0027;

    public new static ExternalLevelCrossingSystemClosePdiCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var CloseReason = (ExternalLevelCrossingSystemClosePdiCommandCloseReason)message[CloseReasonOffset];
        return new ExternalLevelCrossingSystemClosePdiCommand(SenderIdentifier, ReceiverIdentifier, CloseReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.ExternalLevelCrossingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[CloseReasonOffset] = (byte)CloseReason;
        return result;
    }
}

public enum ExternalLevelCrossingSystemClosePdiCommandCloseReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03,
    NormalClose = 0x04,
    OtherVersionRequired = 0x05,
    Timeout = 0x06,
    ChecksumMismatch = 0x07
}


public record AdjacentInterlockingSystemReleasePdiForMaintenanceCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0028;

    public new static AdjacentInterlockingSystemReleasePdiForMaintenanceCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new AdjacentInterlockingSystemReleasePdiForMaintenanceCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.AdjacentInterlockingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record TrainDetectionSystemReleasePdiForMaintenanceCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0028;

    public new static TrainDetectionSystemReleasePdiForMaintenanceCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new TrainDetectionSystemReleasePdiForMaintenanceCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.TrainDetectionSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LightSignalReleasePdiForMaintenanceCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0028;

    public new static LightSignalReleasePdiForMaintenanceCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LightSignalReleasePdiForMaintenanceCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LightSignal;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record PointReleasePdiForMaintenanceCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0028;

    public new static PointReleasePdiForMaintenanceCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new PointReleasePdiForMaintenanceCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.Point;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record RadioBlockCenterReleasePdiForMaintenanceCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0028;

    public new static RadioBlockCenterReleasePdiForMaintenanceCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new RadioBlockCenterReleasePdiForMaintenanceCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.RadioBlockCenter;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LevelCrossingReleasePdiForMaintenanceCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0028;

    public new static LevelCrossingReleasePdiForMaintenanceCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LevelCrossingReleasePdiForMaintenanceCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LevelCrossing;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record CCReleasePdiForMaintenanceCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0028;

    public new static CCReleasePdiForMaintenanceCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new CCReleasePdiForMaintenanceCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.CC;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record GenericIOReleasePdiForMaintenanceCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0028;

    public new static GenericIOReleasePdiForMaintenanceCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new GenericIOReleasePdiForMaintenanceCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.GenericIO;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record ExternalLevelCrossingSystemReleasePdiForMaintenanceCommand (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0028;

    public new static ExternalLevelCrossingSystemReleasePdiForMaintenanceCommand FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new ExternalLevelCrossingSystemReleasePdiForMaintenanceCommand(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.ExternalLevelCrossingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record AdjacentInterlockingSystemPdiAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0029;

    public new static AdjacentInterlockingSystemPdiAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new AdjacentInterlockingSystemPdiAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.AdjacentInterlockingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record TrainDetectionSystemPdiAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0029;

    public new static TrainDetectionSystemPdiAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new TrainDetectionSystemPdiAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.TrainDetectionSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LightSignalPdiAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0029;

    public new static LightSignalPdiAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LightSignalPdiAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LightSignal;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record PointPdiAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0029;

    public new static PointPdiAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new PointPdiAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.Point;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record RadioBlockCenterPdiAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0029;

    public new static RadioBlockCenterPdiAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new RadioBlockCenterPdiAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.RadioBlockCenter;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LevelCrossingPdiAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0029;

    public new static LevelCrossingPdiAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LevelCrossingPdiAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LevelCrossing;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record CCPdiAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0029;

    public new static CCPdiAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new CCPdiAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.CC;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record GenericIOPdiAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0029;

    public new static GenericIOPdiAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new GenericIOPdiAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.GenericIO;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record ExternalLevelCrossingSystemPdiAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x0029;

    public new static ExternalLevelCrossingSystemPdiAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new ExternalLevelCrossingSystemPdiAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.ExternalLevelCrossingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record AdjacentInterlockingSystemPdiNotAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x002A;

    public new static AdjacentInterlockingSystemPdiNotAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new AdjacentInterlockingSystemPdiNotAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.AdjacentInterlockingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record TrainDetectionSystemPdiNotAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x002A;

    public new static TrainDetectionSystemPdiNotAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new TrainDetectionSystemPdiNotAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.TrainDetectionSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LightSignalPdiNotAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x002A;

    public new static LightSignalPdiNotAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LightSignalPdiNotAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LightSignal;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record PointPdiNotAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x002A;

    public new static PointPdiNotAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new PointPdiNotAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.Point;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record RadioBlockCenterPdiNotAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x002A;

    public new static RadioBlockCenterPdiNotAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new RadioBlockCenterPdiNotAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.RadioBlockCenter;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record LevelCrossingPdiNotAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x002A;

    public new static LevelCrossingPdiNotAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new LevelCrossingPdiNotAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.LevelCrossing;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record CCPdiNotAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x002A;

    public new static CCPdiNotAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new CCPdiNotAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.CC;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record GenericIOPdiNotAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x002A;

    public new static GenericIOPdiNotAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new GenericIOPdiNotAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.GenericIO;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record ExternalLevelCrossingSystemPdiNotAvailableMessage (string SenderIdentifier, string ReceiverIdentifier) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    public static readonly ushort MessageType = 0x002A;

    public new static ExternalLevelCrossingSystemPdiNotAvailableMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        return new ExternalLevelCrossingSystemPdiNotAvailableMessage(SenderIdentifier, ReceiverIdentifier);
    }

    public override byte[] ToByteArray() {
        var result = new byte[43];
        result[0] = (byte)ProtocolType.ExternalLevelCrossingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        return result;
    }
}




public record AdjacentInterlockingSystemResetPdiMessage (string SenderIdentifier, string ReceiverIdentifier, AdjacentInterlockingSystemResetPdiMessageResetReason ResetReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int ResetReasonOffset = 43;
    public static readonly ushort MessageType = 0x002B;

    public new static AdjacentInterlockingSystemResetPdiMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var ResetReason = (AdjacentInterlockingSystemResetPdiMessageResetReason)message[ResetReasonOffset];
        return new AdjacentInterlockingSystemResetPdiMessage(SenderIdentifier, ReceiverIdentifier, ResetReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.AdjacentInterlockingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[ResetReasonOffset] = (byte)ResetReason;
        return result;
    }
}

public enum AdjacentInterlockingSystemResetPdiMessageResetReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03
}


public record TrainDetectionSystemResetPdiMessage (string SenderIdentifier, string ReceiverIdentifier, TrainDetectionSystemResetPdiMessageResetReason ResetReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int ResetReasonOffset = 43;
    public static readonly ushort MessageType = 0x002B;

    public new static TrainDetectionSystemResetPdiMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var ResetReason = (TrainDetectionSystemResetPdiMessageResetReason)message[ResetReasonOffset];
        return new TrainDetectionSystemResetPdiMessage(SenderIdentifier, ReceiverIdentifier, ResetReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.TrainDetectionSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[ResetReasonOffset] = (byte)ResetReason;
        return result;
    }
}

public enum TrainDetectionSystemResetPdiMessageResetReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03
}


public record LightSignalResetPdiMessage (string SenderIdentifier, string ReceiverIdentifier, LightSignalResetPdiMessageResetReason ResetReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int ResetReasonOffset = 43;
    public static readonly ushort MessageType = 0x002B;

    public new static LightSignalResetPdiMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var ResetReason = (LightSignalResetPdiMessageResetReason)message[ResetReasonOffset];
        return new LightSignalResetPdiMessage(SenderIdentifier, ReceiverIdentifier, ResetReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.LightSignal;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[ResetReasonOffset] = (byte)ResetReason;
        return result;
    }
}

public enum LightSignalResetPdiMessageResetReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03
}


public record PointResetPdiMessage (string SenderIdentifier, string ReceiverIdentifier, PointResetPdiMessageResetReason ResetReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int ResetReasonOffset = 43;
    public static readonly ushort MessageType = 0x002B;

    public new static PointResetPdiMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var ResetReason = (PointResetPdiMessageResetReason)message[ResetReasonOffset];
        return new PointResetPdiMessage(SenderIdentifier, ReceiverIdentifier, ResetReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.Point;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[ResetReasonOffset] = (byte)ResetReason;
        return result;
    }
}

public enum PointResetPdiMessageResetReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03
}


public record RadioBlockCenterResetPdiMessage (string SenderIdentifier, string ReceiverIdentifier, RadioBlockCenterResetPdiMessageResetReason ResetReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int ResetReasonOffset = 43;
    public static readonly ushort MessageType = 0x002B;

    public new static RadioBlockCenterResetPdiMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var ResetReason = (RadioBlockCenterResetPdiMessageResetReason)message[ResetReasonOffset];
        return new RadioBlockCenterResetPdiMessage(SenderIdentifier, ReceiverIdentifier, ResetReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.RadioBlockCenter;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[ResetReasonOffset] = (byte)ResetReason;
        return result;
    }
}

public enum RadioBlockCenterResetPdiMessageResetReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03
}


public record LevelCrossingResetPdiMessage (string SenderIdentifier, string ReceiverIdentifier, LevelCrossingResetPdiMessageResetReason ResetReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int ResetReasonOffset = 43;
    public static readonly ushort MessageType = 0x002B;

    public new static LevelCrossingResetPdiMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var ResetReason = (LevelCrossingResetPdiMessageResetReason)message[ResetReasonOffset];
        return new LevelCrossingResetPdiMessage(SenderIdentifier, ReceiverIdentifier, ResetReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.LevelCrossing;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[ResetReasonOffset] = (byte)ResetReason;
        return result;
    }
}

public enum LevelCrossingResetPdiMessageResetReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03
}


public record CCResetPdiMessage (string SenderIdentifier, string ReceiverIdentifier, CCResetPdiMessageResetReason ResetReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int ResetReasonOffset = 43;
    public static readonly ushort MessageType = 0x002B;

    public new static CCResetPdiMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var ResetReason = (CCResetPdiMessageResetReason)message[ResetReasonOffset];
        return new CCResetPdiMessage(SenderIdentifier, ReceiverIdentifier, ResetReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.CC;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[ResetReasonOffset] = (byte)ResetReason;
        return result;
    }
}

public enum CCResetPdiMessageResetReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03
}


public record GenericIOResetPdiMessage (string SenderIdentifier, string ReceiverIdentifier, GenericIOResetPdiMessageResetReason ResetReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int ResetReasonOffset = 43;
    public static readonly ushort MessageType = 0x002B;

    public new static GenericIOResetPdiMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var ResetReason = (GenericIOResetPdiMessageResetReason)message[ResetReasonOffset];
        return new GenericIOResetPdiMessage(SenderIdentifier, ReceiverIdentifier, ResetReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.GenericIO;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[ResetReasonOffset] = (byte)ResetReason;
        return result;
    }
}

public enum GenericIOResetPdiMessageResetReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03
}


public record ExternalLevelCrossingSystemResetPdiMessage (string SenderIdentifier, string ReceiverIdentifier, ExternalLevelCrossingSystemResetPdiMessageResetReason ResetReason) : Message(SenderIdentifier, ReceiverIdentifier) {
    private const int MessageTypeOffset = 1;
    private const int SenderIdentifierOffset = 3;
    private const int ReceiverIdentifierOffset = 23;
    private const int ResetReasonOffset = 43;
    public static readonly ushort MessageType = 0x002B;

    public new static ExternalLevelCrossingSystemResetPdiMessage FromBytes(byte[] message) {
        var SenderIdentifier = Encoding.Latin1.GetString(message, SenderIdentifierOffset, 20);
        var ReceiverIdentifier = Encoding.Latin1.GetString(message, ReceiverIdentifierOffset, 20);
        var ResetReason = (ExternalLevelCrossingSystemResetPdiMessageResetReason)message[ResetReasonOffset];
        return new ExternalLevelCrossingSystemResetPdiMessage(SenderIdentifier, ReceiverIdentifier, ResetReason);
    }

    public override byte[] ToByteArray() {
        var result = new byte[44];
        result[0] = (byte)ProtocolType.ExternalLevelCrossingSystem;
        var MessageTypeBytes = BitConverter.GetBytes(MessageType);
        if (!BitConverter.IsLittleEndian) Array.Reverse(MessageTypeBytes);
        MessageTypeBytes.Take(2).ToArray().CopyTo(result, MessageTypeOffset);
        Encoding.Latin1.GetBytes(SenderIdentifier.PadRight(20, '_')).CopyTo(result, SenderIdentifierOffset);
        Encoding.Latin1.GetBytes(ReceiverIdentifier.PadRight(20, '_')).CopyTo(result, ReceiverIdentifierOffset);
        result[ResetReasonOffset] = (byte)ResetReason;
        return result;
    }
}

public enum ExternalLevelCrossingSystemResetPdiMessageResetReason : byte {
    ProtocolError = 0x01,
    FormalTelegramError = 0x02,
    ContentTelegramError = 0x03
}

