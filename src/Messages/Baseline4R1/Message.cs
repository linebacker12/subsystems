using System;

namespace EulynxLive.Messages.Baseline4R1;

public abstract record Message(string ReceiverIdentifier, string SenderIdentifier) {

    public abstract byte[] ToByteArray();

    public static Message FromBytes(byte[] message) {
        var protocolType = (ProtocolType)message[0];
        var messageType = BitConverter.ToUInt16(new byte[2] { message[1], message[2] });
        return protocolType switch {
            ProtocolType.AdjacentInterlockingSystem => messageType switch {
                0x0001 => AdjacentInterlockingSystemActivationZoneStatusMessage.FromBytes(message),
                0x0002 => AdjacentInterlockingSystemApproachZoneStatusMessage.FromBytes(message),
                0x0003 => AdjacentInterlockingSystemAccessRestrictionRequestCommand.FromBytes(message),
                0x0012 => AdjacentInterlockingSystemAccessRestrictionStatusMessage.FromBytes(message),
                0x0004 => AdjacentInterlockingSystemLineStatusMessage.FromBytes(message),
                0x0005 => AdjacentInterlockingSystemFlankProtectionRequestCommand.FromBytes(message),
                0x0013 => AdjacentInterlockingSystemFlankProtectionStatusMessage.FromBytes(message),
                0x0006 => AdjacentInterlockingSystemLineDirectionControlMessage.FromBytes(message),
                0x0007 => AdjacentInterlockingSystemRouteRequestCommand.FromBytes(message),
                0x0008 => AdjacentInterlockingSystemRouteStatusMessage.FromBytes(message),
                0x0009 => AdjacentInterlockingSystemRouteMonitoringStatusMessage.FromBytes(message),
                0x000A => AdjacentInterlockingSystemRouteCancellationRequestCommand.FromBytes(message),
                0x000B => AdjacentInterlockingSystemTrainOperatedRouteReleaseStatusMessage.FromBytes(message),
                0x000C => AdjacentInterlockingSystemSignalStatusMessage.FromBytes(message),
                0x000D => AdjacentInterlockingSystemTvpsStatusMessage.FromBytes(message),
                0x000E => AdjacentInterlockingSystemOppositeMainSignalStatusMessage.FromBytes(message),
                0x000F => AdjacentInterlockingSystemRoutePretestRequestCommand.FromBytes(message),
                0x0010 => AdjacentInterlockingSystemRoutePretestStatusMessage.FromBytes(message),
                0x0011 => AdjacentInterlockingSystemRouteReleaseInhibitionActivationRequestCommand.FromBytes(message),
                0x0014 => AdjacentInterlockingSystemRouteReleaseInhibitionStatusMessage.FromBytes(message),
                0x0024 => AdjacentInterlockingSystemPdiVersionCheckCommand.FromBytes(message),
                0x0025 => AdjacentInterlockingSystemPdiVersionCheckMessage.FromBytes(message),
                0x0021 => AdjacentInterlockingSystemInitialisationRequestCommand.FromBytes(message),
                0x0022 => AdjacentInterlockingSystemStartInitialisationMessage.FromBytes(message),
                0x0026 => AdjacentInterlockingSystemStatusReportCompletedMessage.FromBytes(message),
                0x0023 => AdjacentInterlockingSystemInitialisationCompletedMessage.FromBytes(message),
                0x0027 => AdjacentInterlockingSystemClosePdiCommand.FromBytes(message),
                0x0028 => AdjacentInterlockingSystemReleasePdiForMaintenanceCommand.FromBytes(message),
                0x0029 => AdjacentInterlockingSystemPdiAvailableMessage.FromBytes(message),
                0x002A => AdjacentInterlockingSystemPdiNotAvailableMessage.FromBytes(message),
                0x002B => AdjacentInterlockingSystemResetPdiMessage.FromBytes(message),
                _ => throw new Exception($"Unknown protocol and message type {protocolType} / {messageType}")
            },
            ProtocolType.TrainDetectionSystem => messageType switch {
                0x0001 => TrainDetectionSystemFcCommand.FromBytes(message),
                0x0002 => TrainDetectionSystemUpdateFillingLevelCommand.FromBytes(message),
                0x0008 => TrainDetectionSystemCancelCommand.FromBytes(message),
                0x0003 => TrainDetectionSystemDisableTheRestrictionToForceSectionStatusToClearCommand.FromBytes(message),
                0x0007 => TrainDetectionSystemTvpsOccupancyStatusMessage.FromBytes(message),
                0x0006 => TrainDetectionSystemCommandRejectedMessage.FromBytes(message),
                0x0010 => TrainDetectionSystemTvpsFcPFailedMessage.FromBytes(message),
                0x0011 => TrainDetectionSystemTvpsFcPAFailedMessage.FromBytes(message),
                0x0012 => TrainDetectionSystemAdditionalInformationMessage.FromBytes(message),
                0x000B => TrainDetectionSystemTdpStatusMessage.FromBytes(message),
                0x0024 => TrainDetectionSystemPdiVersionCheckCommand.FromBytes(message),
                0x0025 => TrainDetectionSystemPdiVersionCheckMessage.FromBytes(message),
                0x0021 => TrainDetectionSystemInitialisationRequestCommand.FromBytes(message),
                0x0022 => TrainDetectionSystemStartInitialisationMessage.FromBytes(message),
                0x0026 => TrainDetectionSystemStatusReportCompletedMessage.FromBytes(message),
                0x0023 => TrainDetectionSystemInitialisationCompletedMessage.FromBytes(message),
                0x0027 => TrainDetectionSystemClosePdiCommand.FromBytes(message),
                0x0028 => TrainDetectionSystemReleasePdiForMaintenanceCommand.FromBytes(message),
                0x0029 => TrainDetectionSystemPdiAvailableMessage.FromBytes(message),
                0x002A => TrainDetectionSystemPdiNotAvailableMessage.FromBytes(message),
                0x002B => TrainDetectionSystemResetPdiMessage.FromBytes(message),
                _ => throw new Exception($"Unknown protocol and message type {protocolType} / {messageType}")
            },
            ProtocolType.LightSignal => messageType switch {
                0x0001 => LightSignalIndicateSignalAspectCommand.FromBytes(message),
                0x0002 => LightSignalSetLuminosityCommand.FromBytes(message),
                0x0003 => LightSignalIndicatedSignalAspectMessage.FromBytes(message),
                0x0004 => LightSignalSetLuminosityMessage.FromBytes(message),
                0x0024 => LightSignalPdiVersionCheckCommand.FromBytes(message),
                0x0025 => LightSignalPdiVersionCheckMessage.FromBytes(message),
                0x0021 => LightSignalInitialisationRequestCommand.FromBytes(message),
                0x0022 => LightSignalStartInitialisationMessage.FromBytes(message),
                0x0026 => LightSignalStatusReportCompletedMessage.FromBytes(message),
                0x0023 => LightSignalInitialisationCompletedMessage.FromBytes(message),
                0x0027 => LightSignalClosePdiCommand.FromBytes(message),
                0x0028 => LightSignalReleasePdiForMaintenanceCommand.FromBytes(message),
                0x0029 => LightSignalPdiAvailableMessage.FromBytes(message),
                0x002A => LightSignalPdiNotAvailableMessage.FromBytes(message),
                0x002B => LightSignalResetPdiMessage.FromBytes(message),
                _ => throw new Exception($"Unknown protocol and message type {protocolType} / {messageType}")
            },
            ProtocolType.Point => messageType switch {
                0x0001 => PointMovePointCommand.FromBytes(message),
                0x000B => PointPointPositionMessage.FromBytes(message),
                0x000C => PointTimeoutMessage.FromBytes(message),
                0x000D => PointAbilityToMovePointMessage.FromBytes(message),
                0x0024 => PointPdiVersionCheckCommand.FromBytes(message),
                0x0025 => PointPdiVersionCheckMessage.FromBytes(message),
                0x0021 => PointInitialisationRequestCommand.FromBytes(message),
                0x0022 => PointStartInitialisationMessage.FromBytes(message),
                0x0026 => PointStatusReportCompletedMessage.FromBytes(message),
                0x0023 => PointInitialisationCompletedMessage.FromBytes(message),
                0x0027 => PointClosePdiCommand.FromBytes(message),
                0x0028 => PointReleasePdiForMaintenanceCommand.FromBytes(message),
                0x0029 => PointPdiAvailableMessage.FromBytes(message),
                0x002A => PointPdiNotAvailableMessage.FromBytes(message),
                0x002B => PointResetPdiMessage.FromBytes(message),
                _ => throw new Exception($"Unknown protocol and message type {protocolType} / {messageType}")
            },
            ProtocolType.RadioBlockCenter => messageType switch {
                0x0024 => RadioBlockCenterPdiVersionCheckCommand.FromBytes(message),
                0x0025 => RadioBlockCenterPdiVersionCheckMessage.FromBytes(message),
                0x0021 => RadioBlockCenterInitialisationRequestCommand.FromBytes(message),
                0x0022 => RadioBlockCenterStartInitialisationMessage.FromBytes(message),
                0x0026 => RadioBlockCenterStatusReportCompletedMessage.FromBytes(message),
                0x0023 => RadioBlockCenterInitialisationCompletedMessage.FromBytes(message),
                0x0027 => RadioBlockCenterClosePdiCommand.FromBytes(message),
                0x0028 => RadioBlockCenterReleasePdiForMaintenanceCommand.FromBytes(message),
                0x0029 => RadioBlockCenterPdiAvailableMessage.FromBytes(message),
                0x002A => RadioBlockCenterPdiNotAvailableMessage.FromBytes(message),
                0x002B => RadioBlockCenterResetPdiMessage.FromBytes(message),
                _ => throw new Exception($"Unknown protocol and message type {protocolType} / {messageType}")
            },
            ProtocolType.LevelCrossing => messageType switch {
                0x0002 => LevelCrossingDeactivationCommand.FromBytes(message),
                0x0024 => LevelCrossingPdiVersionCheckCommand.FromBytes(message),
                0x0025 => LevelCrossingPdiVersionCheckMessage.FromBytes(message),
                0x0021 => LevelCrossingInitialisationRequestCommand.FromBytes(message),
                0x0022 => LevelCrossingStartInitialisationMessage.FromBytes(message),
                0x0026 => LevelCrossingStatusReportCompletedMessage.FromBytes(message),
                0x0023 => LevelCrossingInitialisationCompletedMessage.FromBytes(message),
                0x0027 => LevelCrossingClosePdiCommand.FromBytes(message),
                0x0028 => LevelCrossingReleasePdiForMaintenanceCommand.FromBytes(message),
                0x0029 => LevelCrossingPdiAvailableMessage.FromBytes(message),
                0x002A => LevelCrossingPdiNotAvailableMessage.FromBytes(message),
                0x002B => LevelCrossingResetPdiMessage.FromBytes(message),
                _ => throw new Exception($"Unknown protocol and message type {protocolType} / {messageType}")
            },
            ProtocolType.CC => messageType switch {
                0x0050 => message[45] switch {
                    0x2B => CCManageATrackSectionCommand.FromBytes(message),
                    0x96 => CCSetPredefinedObstructionCommand.FromBytes(message),
                    0x2C => CCReleaseMovementAuthorityCommand.FromBytes(message),
                    0xA0 => CCReleaseForNormalOperationCommand.FromBytes(message)
                },
                0x0055 => message[45] switch {
                    0x2B => CCManageATrackSectionCommand.FromBytes(message),
                    0x96 => CCSetPredefinedObstructionCommand.FromBytes(message),
                    0x2C => CCReleaseMovementAuthorityCommand.FromBytes(message),
                    0xA0 => CCReleaseForNormalOperationCommand.FromBytes(message)
                },
                0x0040 => CCPredefinedObstructionStatusMessage.FromBytes(message),
                0x0065 => CCAbortCommandCommand.FromBytes(message),
                0x0060 => CCConfirmationOfACommandWithSafetyCodesCommand.FromBytes(message),
                0x0044 => CCCommandAcceptedMessage.FromBytes(message),
                0x0024 => CCPdiVersionCheckCommand.FromBytes(message),
                0x0025 => CCPdiVersionCheckMessage.FromBytes(message),
                0x0021 => CCInitialisationRequestCommand.FromBytes(message),
                0x0022 => CCStartInitialisationMessage.FromBytes(message),
                0x0026 => CCStatusReportCompletedMessage.FromBytes(message),
                0x0023 => CCInitialisationCompletedMessage.FromBytes(message),
                0x0027 => CCClosePdiCommand.FromBytes(message),
                0x0028 => CCReleasePdiForMaintenanceCommand.FromBytes(message),
                0x0029 => CCPdiAvailableMessage.FromBytes(message),
                0x002A => CCPdiNotAvailableMessage.FromBytes(message),
                0x002B => CCResetPdiMessage.FromBytes(message),
                _ => throw new Exception($"Unknown protocol and message type {protocolType} / {messageType}")
            },
            ProtocolType.GenericIO => messageType switch {
                0x0024 => GenericIOPdiVersionCheckCommand.FromBytes(message),
                0x0025 => GenericIOPdiVersionCheckMessage.FromBytes(message),
                0x0021 => GenericIOInitialisationRequestCommand.FromBytes(message),
                0x0022 => GenericIOStartInitialisationMessage.FromBytes(message),
                0x0026 => GenericIOStatusReportCompletedMessage.FromBytes(message),
                0x0023 => GenericIOInitialisationCompletedMessage.FromBytes(message),
                0x0027 => GenericIOClosePdiCommand.FromBytes(message),
                0x0028 => GenericIOReleasePdiForMaintenanceCommand.FromBytes(message),
                0x0029 => GenericIOPdiAvailableMessage.FromBytes(message),
                0x002A => GenericIOPdiNotAvailableMessage.FromBytes(message),
                0x002B => GenericIOResetPdiMessage.FromBytes(message),
                _ => throw new Exception($"Unknown protocol and message type {protocolType} / {messageType}")
            },
            ProtocolType.ExternalLevelCrossingSystem => messageType switch {
                0x0007 => ExternalLevelCrossingSystemCrossingClearCommand.FromBytes(message),
                0x0024 => ExternalLevelCrossingSystemPdiVersionCheckCommand.FromBytes(message),
                0x0025 => ExternalLevelCrossingSystemPdiVersionCheckMessage.FromBytes(message),
                0x0021 => ExternalLevelCrossingSystemInitialisationRequestCommand.FromBytes(message),
                0x0022 => ExternalLevelCrossingSystemStartInitialisationMessage.FromBytes(message),
                0x0026 => ExternalLevelCrossingSystemStatusReportCompletedMessage.FromBytes(message),
                0x0023 => ExternalLevelCrossingSystemInitialisationCompletedMessage.FromBytes(message),
                0x0027 => ExternalLevelCrossingSystemClosePdiCommand.FromBytes(message),
                0x0028 => ExternalLevelCrossingSystemReleasePdiForMaintenanceCommand.FromBytes(message),
                0x0029 => ExternalLevelCrossingSystemPdiAvailableMessage.FromBytes(message),
                0x002A => ExternalLevelCrossingSystemPdiNotAvailableMessage.FromBytes(message),
                0x002B => ExternalLevelCrossingSystemResetPdiMessage.FromBytes(message),
                _ => throw new Exception($"Unknown protocol and message type {protocolType} / {messageType}")
            },
            _ => throw new Exception($"Unknown protocol and message type {protocolType} / {messageType}")
        };
    }
}
