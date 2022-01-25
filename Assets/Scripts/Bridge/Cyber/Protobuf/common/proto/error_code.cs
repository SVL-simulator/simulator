// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: error_code.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.common
{

    [global::ProtoBuf.ProtoContract()]
    public partial class StatusPb : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public StatusPb()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(ErrorCode.Ok)]
        public ErrorCode error_code
        {
            get { return __pbn__error_code ?? ErrorCode.Ok; }
            set { __pbn__error_code = value; }
        }
        public bool ShouldSerializeerror_code()
        {
            return __pbn__error_code != null;
        }
        public void Reseterror_code()
        {
            __pbn__error_code = null;
        }
        private ErrorCode? __pbn__error_code;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string msg
        {
            get { return __pbn__msg ?? ""; }
            set { __pbn__msg = value; }
        }
        public bool ShouldSerializemsg()
        {
            return __pbn__msg != null;
        }
        public void Resetmsg()
        {
            __pbn__msg = null;
        }
        private string __pbn__msg;

    }

    [global::ProtoBuf.ProtoContract()]
    public enum ErrorCode
    {
        [global::ProtoBuf.ProtoEnum(Name = @"OK")]
        Ok = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"CONTROL_ERROR")]
        ControlError = 1000,
        [global::ProtoBuf.ProtoEnum(Name = @"CONTROL_INIT_ERROR")]
        ControlInitError = 1001,
        [global::ProtoBuf.ProtoEnum(Name = @"CONTROL_COMPUTE_ERROR")]
        ControlComputeError = 1002,
        [global::ProtoBuf.ProtoEnum(Name = @"CANBUS_ERROR")]
        CanbusError = 2000,
        [global::ProtoBuf.ProtoEnum(Name = @"CAN_CLIENT_ERROR_BASE")]
        CanClientErrorBase = 2100,
        [global::ProtoBuf.ProtoEnum(Name = @"CAN_CLIENT_ERROR_OPEN_DEVICE_FAILED")]
        CanClientErrorOpenDeviceFailed = 2101,
        [global::ProtoBuf.ProtoEnum(Name = @"CAN_CLIENT_ERROR_FRAME_NUM")]
        CanClientErrorFrameNum = 2102,
        [global::ProtoBuf.ProtoEnum(Name = @"CAN_CLIENT_ERROR_SEND_FAILED")]
        CanClientErrorSendFailed = 2103,
        [global::ProtoBuf.ProtoEnum(Name = @"CAN_CLIENT_ERROR_RECV_FAILED")]
        CanClientErrorRecvFailed = 2104,
        [global::ProtoBuf.ProtoEnum(Name = @"LOCALIZATION_ERROR")]
        LocalizationError = 3000,
        [global::ProtoBuf.ProtoEnum(Name = @"LOCALIZATION_ERROR_MSG")]
        LocalizationErrorMsg = 3100,
        [global::ProtoBuf.ProtoEnum(Name = @"LOCALIZATION_ERROR_LIDAR")]
        LocalizationErrorLidar = 3200,
        [global::ProtoBuf.ProtoEnum(Name = @"LOCALIZATION_ERROR_INTEG")]
        LocalizationErrorInteg = 3300,
        [global::ProtoBuf.ProtoEnum(Name = @"LOCALIZATION_ERROR_GNSS")]
        LocalizationErrorGnss = 3400,
        [global::ProtoBuf.ProtoEnum(Name = @"PERCEPTION_ERROR")]
        PerceptionError = 4000,
        [global::ProtoBuf.ProtoEnum(Name = @"PERCEPTION_ERROR_TF")]
        PerceptionErrorTf = 4001,
        [global::ProtoBuf.ProtoEnum(Name = @"PERCEPTION_ERROR_PROCESS")]
        PerceptionErrorProcess = 4002,
        [global::ProtoBuf.ProtoEnum(Name = @"PERCEPTION_FATAL")]
        PerceptionFatal = 4003,
        [global::ProtoBuf.ProtoEnum(Name = @"PERCEPTION_ERROR_NONE")]
        PerceptionErrorNone = 4004,
        [global::ProtoBuf.ProtoEnum(Name = @"PERCEPTION_ERROR_UNKNOWN")]
        PerceptionErrorUnknown = 4005,
        [global::ProtoBuf.ProtoEnum(Name = @"PREDICTION_ERROR")]
        PredictionError = 5000,
        [global::ProtoBuf.ProtoEnum(Name = @"PLANNING_ERROR")]
        PlanningError = 6000,
        [global::ProtoBuf.ProtoEnum(Name = @"PLANNING_ERROR_NOT_READY")]
        PlanningErrorNotReady = 6001,
        [global::ProtoBuf.ProtoEnum(Name = @"HDMAP_DATA_ERROR")]
        HdmapDataError = 7000,
        [global::ProtoBuf.ProtoEnum(Name = @"ROUTING_ERROR")]
        RoutingError = 8000,
        [global::ProtoBuf.ProtoEnum(Name = @"ROUTING_ERROR_REQUEST")]
        RoutingErrorRequest = 8001,
        [global::ProtoBuf.ProtoEnum(Name = @"ROUTING_ERROR_RESPONSE")]
        RoutingErrorResponse = 8002,
        [global::ProtoBuf.ProtoEnum(Name = @"ROUTING_ERROR_NOT_READY")]
        RoutingErrorNotReady = 8003,
        [global::ProtoBuf.ProtoEnum(Name = @"END_OF_INPUT")]
        EndOfInput = 9000,
        [global::ProtoBuf.ProtoEnum(Name = @"HTTP_LOGIC_ERROR")]
        HttpLogicError = 10000,
        [global::ProtoBuf.ProtoEnum(Name = @"HTTP_RUNTIME_ERROR")]
        HttpRuntimeError = 10001,
        [global::ProtoBuf.ProtoEnum(Name = @"RELATIVE_MAP_ERROR")]
        RelativeMapError = 11000,
        [global::ProtoBuf.ProtoEnum(Name = @"RELATIVE_MAP_NOT_READY")]
        RelativeMapNotReady = 11001,
        [global::ProtoBuf.ProtoEnum(Name = @"DRIVER_ERROR_GNSS")]
        DriverErrorGnss = 12000,
        [global::ProtoBuf.ProtoEnum(Name = @"DRIVER_ERROR_VELODYNE")]
        DriverErrorVelodyne = 13000,
    }

}

#pragma warning restore 0612, 1591, 3021
