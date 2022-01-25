// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: map_lane.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.hdmap
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LaneBoundaryType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LaneBoundaryType()
        {
            types = new global::System.Collections.Generic.List<Type>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double s
        {
            get { return __pbn__s.GetValueOrDefault(); }
            set { __pbn__s = value; }
        }
        public bool ShouldSerializes()
        {
            return __pbn__s != null;
        }
        public void Resets()
        {
            __pbn__s = null;
        }
        private double? __pbn__s;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<Type> types { get; private set; }

        [global::ProtoBuf.ProtoContract()]
        public enum Type
        {
            [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
            Unknown = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"DOTTED_YELLOW")]
            DottedYellow = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"DOTTED_WHITE")]
            DottedWhite = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"SOLID_YELLOW")]
            SolidYellow = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"SOLID_WHITE")]
            SolidWhite = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"DOUBLE_YELLOW")]
            DoubleYellow = 5,
            [global::ProtoBuf.ProtoEnum(Name = @"CURB")]
            Curb = 6,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LaneBoundary : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LaneBoundary()
        {
            boundary_type = new global::System.Collections.Generic.List<LaneBoundaryType>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Curve curve { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public double length
        {
            get { return __pbn__length.GetValueOrDefault(); }
            set { __pbn__length = value; }
        }
        public bool ShouldSerializelength()
        {
            return __pbn__length != null;
        }
        public void Resetlength()
        {
            __pbn__length = null;
        }
        private double? __pbn__length;

        [global::ProtoBuf.ProtoMember(3)]
        public bool @virtual
        {
            get { return __pbn__virtual.GetValueOrDefault(); }
            set { __pbn__virtual = value; }
        }
        public bool ShouldSerializevirtual()
        {
            return __pbn__virtual != null;
        }
        public void Resetvirtual()
        {
            __pbn__virtual = null;
        }
        private bool? __pbn__virtual;

        [global::ProtoBuf.ProtoMember(4)]
        public global::System.Collections.Generic.List<LaneBoundaryType> boundary_type { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LaneSampleAssociation : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LaneSampleAssociation()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double s
        {
            get { return __pbn__s.GetValueOrDefault(); }
            set { __pbn__s = value; }
        }
        public bool ShouldSerializes()
        {
            return __pbn__s != null;
        }
        public void Resets()
        {
            __pbn__s = null;
        }
        private double? __pbn__s;

        [global::ProtoBuf.ProtoMember(2)]
        public double width
        {
            get { return __pbn__width.GetValueOrDefault(); }
            set { __pbn__width = value; }
        }
        public bool ShouldSerializewidth()
        {
            return __pbn__width != null;
        }
        public void Resetwidth()
        {
            __pbn__width = null;
        }
        private double? __pbn__width;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Lane : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Lane()
        {
            overlap_id = new global::System.Collections.Generic.List<Id>();
            predecessor_id = new global::System.Collections.Generic.List<Id>();
            successor_id = new global::System.Collections.Generic.List<Id>();
            left_neighbor_forward_lane_id = new global::System.Collections.Generic.List<Id>();
            right_neighbor_forward_lane_id = new global::System.Collections.Generic.List<Id>();
            left_neighbor_reverse_lane_id = new global::System.Collections.Generic.List<Id>();
            right_neighbor_reverse_lane_id = new global::System.Collections.Generic.List<Id>();
            left_sample = new global::System.Collections.Generic.List<LaneSampleAssociation>();
            right_sample = new global::System.Collections.Generic.List<LaneSampleAssociation>();
            left_road_sample = new global::System.Collections.Generic.List<LaneSampleAssociation>();
            right_road_sample = new global::System.Collections.Generic.List<LaneSampleAssociation>();
            self_reverse_lane_id = new global::System.Collections.Generic.List<Id>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Id id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public Curve central_curve { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public LaneBoundary left_boundary { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public LaneBoundary right_boundary { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public double length
        {
            get { return __pbn__length.GetValueOrDefault(); }
            set { __pbn__length = value; }
        }
        public bool ShouldSerializelength()
        {
            return __pbn__length != null;
        }
        public void Resetlength()
        {
            __pbn__length = null;
        }
        private double? __pbn__length;

        [global::ProtoBuf.ProtoMember(6)]
        public double speed_limit
        {
            get { return __pbn__speed_limit.GetValueOrDefault(); }
            set { __pbn__speed_limit = value; }
        }
        public bool ShouldSerializespeed_limit()
        {
            return __pbn__speed_limit != null;
        }
        public void Resetspeed_limit()
        {
            __pbn__speed_limit = null;
        }
        private double? __pbn__speed_limit;

        [global::ProtoBuf.ProtoMember(7)]
        public global::System.Collections.Generic.List<Id> overlap_id { get; private set; }

        [global::ProtoBuf.ProtoMember(8)]
        public global::System.Collections.Generic.List<Id> predecessor_id { get; private set; }

        [global::ProtoBuf.ProtoMember(9)]
        public global::System.Collections.Generic.List<Id> successor_id { get; private set; }

        [global::ProtoBuf.ProtoMember(10)]
        public global::System.Collections.Generic.List<Id> left_neighbor_forward_lane_id { get; private set; }

        [global::ProtoBuf.ProtoMember(11)]
        public global::System.Collections.Generic.List<Id> right_neighbor_forward_lane_id { get; private set; }

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue(LaneType.None)]
        public LaneType type
        {
            get { return __pbn__type ?? LaneType.None; }
            set { __pbn__type = value; }
        }
        public bool ShouldSerializetype()
        {
            return __pbn__type != null;
        }
        public void Resettype()
        {
            __pbn__type = null;
        }
        private LaneType? __pbn__type;

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue(LaneTurn.NoTurn)]
        public LaneTurn turn
        {
            get { return __pbn__turn ?? LaneTurn.NoTurn; }
            set { __pbn__turn = value; }
        }
        public bool ShouldSerializeturn()
        {
            return __pbn__turn != null;
        }
        public void Resetturn()
        {
            __pbn__turn = null;
        }
        private LaneTurn? __pbn__turn;

        [global::ProtoBuf.ProtoMember(14)]
        public global::System.Collections.Generic.List<Id> left_neighbor_reverse_lane_id { get; private set; }

        [global::ProtoBuf.ProtoMember(15)]
        public global::System.Collections.Generic.List<Id> right_neighbor_reverse_lane_id { get; private set; }

        [global::ProtoBuf.ProtoMember(16)]
        public Id junction_id { get; set; }

        [global::ProtoBuf.ProtoMember(17)]
        public global::System.Collections.Generic.List<LaneSampleAssociation> left_sample { get; private set; }

        [global::ProtoBuf.ProtoMember(18)]
        public global::System.Collections.Generic.List<LaneSampleAssociation> right_sample { get; private set; }

        [global::ProtoBuf.ProtoMember(19)]
        [global::System.ComponentModel.DefaultValue(LaneDirection.Forward)]
        public LaneDirection direction
        {
            get { return __pbn__direction ?? LaneDirection.Forward; }
            set { __pbn__direction = value; }
        }
        public bool ShouldSerializedirection()
        {
            return __pbn__direction != null;
        }
        public void Resetdirection()
        {
            __pbn__direction = null;
        }
        private LaneDirection? __pbn__direction;

        [global::ProtoBuf.ProtoMember(20)]
        public global::System.Collections.Generic.List<LaneSampleAssociation> left_road_sample { get; private set; }

        [global::ProtoBuf.ProtoMember(21)]
        public global::System.Collections.Generic.List<LaneSampleAssociation> right_road_sample { get; private set; }

        [global::ProtoBuf.ProtoMember(22)]
        public global::System.Collections.Generic.List<Id> self_reverse_lane_id { get; private set; }

        [global::ProtoBuf.ProtoContract()]
        public enum LaneType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"NONE")]
            None = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"CITY_DRIVING")]
            CityDriving = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"BIKING")]
            Biking = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"SIDEWALK")]
            Sidewalk = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"PARKING")]
            Parking = 5,
            [global::ProtoBuf.ProtoEnum(Name = @"SHOULDER")]
            Shoulder = 6,
        }

        [global::ProtoBuf.ProtoContract()]
        public enum LaneTurn
        {
            [global::ProtoBuf.ProtoEnum(Name = @"NO_TURN")]
            NoTurn = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"LEFT_TURN")]
            LeftTurn = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"RIGHT_TURN")]
            RightTurn = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"U_TURN")]
            UTurn = 4,
        }

        [global::ProtoBuf.ProtoContract()]
        public enum LaneDirection
        {
            [global::ProtoBuf.ProtoEnum(Name = @"FORWARD")]
            Forward = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"BACKWARD")]
            Backward = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"BIDIRECTION")]
            Bidirection = 3,
        }

    }

}

#pragma warning restore 0612, 1591, 3021
