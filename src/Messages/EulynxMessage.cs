using System;
using System.Text;

namespace EulynxLive.Messages
{
    public abstract class EulynxMessage
    {
        protected const int PROTOCOL_TYPE_OFFSET = 0;
        protected const int MESSAGE_TYPE_OFFSET = 1;
        protected const int SENDER_IDENTIFIER_OFFSET = 3;
        protected const int RECEIVER_IDENTIFIER_OFFSET = 23;

        public virtual ProtocolType ProtocolType { get; }
        public abstract ushort MessageTypeRaw { get; }
        public string SenderId { get; }
        public string ReceiverId { get; }
        public abstract int Size { get; }

        public EulynxMessage(string senderId, string receiverId)
        {
            SenderId = senderId;
            ReceiverId = receiverId;
        }

        public static EulynxMessage FromBytes(byte[] message)
        {
            var protocolType = (ProtocolType)message[PROTOCOL_TYPE_OFFSET];
            var messageType = BitConverter.ToUInt16(
                new byte[2] { message[MESSAGE_TYPE_OFFSET], message[MESSAGE_TYPE_OFFSET + 1] });
            var senderId = Encoding.UTF8.GetString(message, SENDER_IDENTIFIER_OFFSET, 20);
            var receiverId = Encoding.UTF8.GetString(message, RECEIVER_IDENTIFIER_OFFSET, 20);

            switch (protocolType)
            {
                case ProtocolType.TrainDetectionSystem:
                    switch ((TrainDetectionSystemMessageType)messageType)
                    {
                        case TrainDetectionSystemMessageType.VersionCheckCommand:
                            return TrainDetectionSystemVersionCheckCommand.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.VersionCheckMessage:
                            return TrainDetectionSystemVersionCheckMessage.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.PDIAvailable:
                            return TrainDetectionSystemPDIAvailableMessage.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.PDINotAvailable:
                            return TrainDetectionSystemPDINotAvailableMessage.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.InitializationRequest:
                            return TrainDetectionSystemInitializationRequestMessage.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.StartInitialization:
                            return TrainDetectionSystemStartInitializationMessage.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.InitializationCompleted:
                            return TrainDetectionSystemInitializationCompletedMessage.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.ForceClearCommand:
                            return TrainDetectionSystemForceClearCommand.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.UpdateFillingLevelCommand:
                            return TrainDetectionSystemUpdateFillingLevelCommand.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.DRFCCommand:
                            return TrainDetectionSystemDRFCCommand.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.TDPActivationCommand:
                            return TrainDetectionSystemTDPActivationCommand.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.TvpsOccupancyStatusMessage:
                            if (message.Length == 45) {
                                return TrainDetectionSystemTvpsOccupancyStatusMessageNeuPro.Parse(senderId, receiverId, message);
                            } else if (message.Length == 47) {
                                return TrainDetectionSystemTvpsOccupancyStatusMessageNeuProThales.Parse(senderId, receiverId, message);
                            } else if (message.Length == 48) {
                                return TrainDetectionSystemTvpsOccupancyStatusMessage.Parse(senderId, receiverId, message);
                            }
                            break;
                        case TrainDetectionSystemMessageType.CommandRejectedMessage:
                            return TrainDetectionSystemCommandRejectedMessage.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.DRFCReceiptMessage:
                            return TrainDetectionSystemDRFCReceiptMessage.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.TvpsFCPFailedMessage:
                            return TrainDetectionSystemTvpsFCPFailedMessage.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.TvpsFCPAFailedMessage:
                            return TrainDetectionSystemTvpsFCPAFailedMessage.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.AdditionalInformationMessage:
                            return TrainDetectionSystemAdditionalInformationMessage.Parse(senderId, receiverId, message);
                        case TrainDetectionSystemMessageType.TDPStatusMessage:
                            return TrainDetectionSystemTDPStatusMessage.Parse(senderId, receiverId, message);
                    }
                    break;
                case ProtocolType.LightSignal:
                    switch ((LightSignalMessageType)messageType)
                    {
                        case LightSignalMessageType.IndicateSignalAspect:
                            return LightSignalIndicateSignalAspectCommand.Parse(senderId, receiverId, message);
                        case LightSignalMessageType.IndicatedSignalAspect:
                            return LightSignalIndicatedSignalAspectMessage.Parse(senderId, receiverId, message);
                        case LightSignalMessageType.VersionCheckCommand:
                            return LightSignalVersionCheckCommand.Parse(senderId, receiverId, message);
                        case LightSignalMessageType.VersionCheckMessage:
                            return LightSignalVersionCheckMessage.Parse(senderId, receiverId, message);
                        case LightSignalMessageType.PDIAvailable:
                            return LightSignalPDIAvailableMessage.Parse(senderId, receiverId, message);
                        case LightSignalMessageType.PDINotAvailable:
                            return LightSignalPDINotAvailableMessage.Parse(senderId, receiverId, message);
                        case LightSignalMessageType.InitializationRequest:
                            return LightSignalInitializationRequestMessage.Parse(senderId, receiverId, message);
                        case LightSignalMessageType.StartInitialization:
                            return LightSignalStartInitializationMessage.Parse(senderId, receiverId, message);
                        case LightSignalMessageType.InitializationCompleted:
                            return LightSignalInitializationCompletedMessage.Parse(senderId, receiverId, message);
                        case LightSignalMessageType.SetLuminosityMessage:
                            return LightSignalSetLuminosityMessage.Parse(senderId, receiverId, message);
                        // Work in progress:
                        case LightSignalMessageType.SetLuminosityCommand:
                            throw new NotImplementedException();
                        //     return LightSignalSetLuminosityCommand.Parse(senderId, receiverId, message);
                    }
                    break;
                case ProtocolType.Point:
                    switch ((PointMessageType)messageType)
                    {
                        case PointMessageType.MovePointCommand:
                            return PointMovePointCommand.Parse(senderId, receiverId, message);
                        case PointMessageType.PointPositionMessage:
                            return PointPositionMessage.Parse(senderId, receiverId, message);
                        case PointMessageType.TimeoutMessage:
                            return PointTimeoutMessage.Parse(senderId, receiverId, message);
                        case PointMessageType.VersionCheckCommand:
                            return PointVersionCheckCommand.Parse(senderId, receiverId, message);
                        case PointMessageType.VersionCheckMessage:
                            return PointVersionCheckMessage.Parse(senderId, receiverId, message);
                        case PointMessageType.PDIAvailable:
                            return PointPDIAvailableMessage.Parse(senderId, receiverId, message);
                        case PointMessageType.PDINotAvailable:
                            return PointPDINotAvailableMessage.Parse(senderId, receiverId, message);
                        case PointMessageType.InitializationRequest:
                            return PointInitializationRequestMessage.Parse(senderId, receiverId, message);
                        case PointMessageType.StartInitialization:
                            return PointStartInitializationMessage.Parse(senderId, receiverId, message);
                        case PointMessageType.InitializationCompleted:
                            return PointInitializationCompletedMessage.Parse(senderId, receiverId, message);
                    }
                    break;
                case ProtocolType.LevelCrossing:
                    // NeuPro
                    switch ((NeuPro.LevelCrossingMessageType)messageType) {
                        case NeuPro.LevelCrossingMessageType.AnFsüCommand:
                            return NeuPro.AnFsüCommand.Parse(senderId, receiverId, message);
                        case NeuPro.LevelCrossingMessageType.AusFsüCommand:
                            return NeuPro.AusFsüCommand.Parse(senderId, receiverId, message);
                        case NeuPro.LevelCrossingMessageType.MeldungZustandGleisbezogenMessage:
                            return NeuPro.MeldungZustandGleisbezogenMessage.Parse(senderId, receiverId, message);
                        case NeuPro.LevelCrossingMessageType.MeldungZustandBüBezogenMessage:
                            return NeuPro.MeldungZustandBüBezogenMessage.Parse(senderId, receiverId, message);

                        case NeuPro.LevelCrossingMessageType.InitializationRequest:
                            return NeuPro.LevelCrossingInitializationRequestMessage.Parse(senderId, receiverId, message);
                        case NeuPro.LevelCrossingMessageType.StartInitialization:
                            return NeuPro.LevelCrossingStartInitializationMessage.Parse(senderId, receiverId, message);
                        case NeuPro.LevelCrossingMessageType.InitializationCompleted:
                            return NeuPro.LevelCrossingInitializationCompletedMessage.Parse(senderId, receiverId, message);
                        case NeuPro.LevelCrossingMessageType.VersionCheckCommand:
                            return NeuPro.LevelCrossingVersionCheckCommand.Parse(senderId, receiverId, message);
                        case NeuPro.LevelCrossingMessageType.VersionCheckMessage:
                            return NeuPro.LevelCrossingVersionCheckMessage.Parse(senderId, receiverId, message);
                        // Not sure if these exist:
                        case NeuPro.LevelCrossingMessageType.PDIAvailable:
                            return NeuPro.LevelCrossingPDIAvailableMessage.Parse(senderId, receiverId, message);
                        case NeuPro.LevelCrossingMessageType.PDINotAvailable:
                            return NeuPro.LevelCrossingPDINotAvailableMessage.Parse(senderId, receiverId, message);
                    }
                    break;
                case ProtocolType.ExternalLevelCrossingSystem:
                    switch ((ExternalLevelCrossingSystemMessageType)messageType) {
                        case ExternalLevelCrossingSystemMessageType.LxActivationCommand:
                            return ExternalLevelCrossingSystemLxActivationCommand.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.TrActivationCommand:
                            return ExternalLevelCrossingSystemTrActivationCommand.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.LxDeactivationCommand:
                            return ExternalLevelCrossingSystemLxDeactivationCommand.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.TrDeactivationCommand:
                            return ExternalLevelCrossingSystemTrDeactivationCommand.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.ControlActivationPointCommand:
                            return ExternalLevelCrossingSystemControlActivationPointCommand.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.TrackRelatedProlongActivationCommand:
                            return ExternalLevelCrossingSystemTrackRelatedProlongActivationCommand.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.CrossingClearCommand:
                            return ExternalLevelCrossingSystemCrossingClearCommand.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.BlockLxCommand:
                            return ExternalLevelCrossingSystemBlockLxCommand.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.TrackRelatedIsolationCommand:
                            return ExternalLevelCrossingSystemTrackRelatedIsolationCommand.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.LxFunctionalStatusMessage:
                            return ExternalLevelCrossingSystemLxFunctionalStatusMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.TrFunctionalStatusMessage:
                            return ExternalLevelCrossingSystemTrFunctionalStatusMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.ObstacleDetectionStatusMessage:
                            return ExternalLevelCrossingSystemObstacleDetectionStatusMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.DetectionElementStatusMessage:
                            return ExternalLevelCrossingSystemDetectionElementStatusMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.LxMonitoringStatusMessage:
                            return ExternalLevelCrossingSystemLxMonitoringStatusMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.TrMonitoringStatusMessage:
                            return ExternalLevelCrossingSystemTrMonitoringStatusMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.LxFailureStatusMessage:
                            return ExternalLevelCrossingSystemLxFailureStatusMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.TrFailureStatusMessage:
                            return ExternalLevelCrossingSystemTrFailureStatusMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.TrackRelatedCommandAdmissabilityMessage:
                            return ExternalLevelCrossingSystemTrackRelatedCommandAdmissabilityMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.LxCommandAdmissibilityMessage:
                            return ExternalLevelCrossingSystemLxCommandAdmissibilityMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.StatusOfActivationPointMessage:
                            return ExternalLevelCrossingSystemStatusOfActivationPointMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.InitializationRequest:
                            return ExternalLevelCrossingSystemInitializationRequestMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.StartInitialization:
                            return ExternalLevelCrossingSystemStartInitializationMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.InitializationCompleted:
                            return ExternalLevelCrossingSystemInitializationCompletedMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.VersionCheckCommand:
                            return ExternalLevelCrossingSystemVersionCheckCommand.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.VersionCheckMessage:
                            return ExternalLevelCrossingSystemVersionCheckMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.PDIAvailable:
                            return ExternalLevelCrossingSystemPDIAvailableMessage.Parse(senderId, receiverId, message);
                        case ExternalLevelCrossingSystemMessageType.PDINotAvailable:
                            return ExternalLevelCrossingSystemPDINotAvailableMessage.Parse(senderId, receiverId, message);
                    }
                    break;
            }

            throw new ArgumentException("Invalid EULYNX message: " + BitConverter.ToString(message));
        }

        public byte[] ToByteArray()
        {
            var bytes = new byte[Size];
            bytes[PROTOCOL_TYPE_OFFSET] = (byte)ProtocolType;
            bytes[MESSAGE_TYPE_OFFSET] = (byte)MessageTypeRaw;
            bytes[MESSAGE_TYPE_OFFSET + 1] = (byte)(MessageTypeRaw >> 8);
            Encoding.UTF8.GetBytes(SenderId.PadRight(20, '_')).CopyTo(bytes, SENDER_IDENTIFIER_OFFSET);
            Encoding.UTF8.GetBytes(ReceiverId.PadRight(20, '_')).CopyTo(bytes, RECEIVER_IDENTIFIER_OFFSET);

            WritePayloadToByteArray(bytes);

            return bytes;
        }

        protected abstract void WritePayloadToByteArray(byte[] bytes);
    }
}
